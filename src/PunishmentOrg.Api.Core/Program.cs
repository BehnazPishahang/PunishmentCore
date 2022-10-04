using Anu.BaseInfo.ServiceModel.Validation.Attachment;
using Anu.DataAccess;
using Anu.Domain;
using Anu.PunishmentOrg.Api.Authentication;
using Anu.PunishmentOrg.Api.Authentication.Utility;
using Anu.PunishmentOrg.ServiceModel.Validation.Gravamen;
using Anu.Utility.Logger.File;
using Anu.Utility.Sms;
using Anu.Validation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Utility;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(options =>
{
    var policy = new Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    options.Filters.Add(new Microsoft.AspNetCore.Mvc.Authorization.AuthorizeFilter(policy));
    //options.Filters.Add<ServiceModelValidationFilterAttribute>();
    
}).AddFluentValidation(options => {
                                    /*
                                     * 
                                     * اگر در
                                     * DataAnnotation
                                     * ها مانند 
                                     * [System.ComponentModel.DataAnnotations.Required]
                                     * [System.ComponentModel.DataAnnotations.MinLength(1)]
                                     * خطایی اتفاق بیافتد دیگر به ولیدیشن های 
                                     * شخصی سازی شده که برنامه نویس می نویسد نمی رسد 
                                     * و جزییات خطاها از همانجا
                                     * به بیرون برگشت داده می شود
                                     * 
                                     * پس برای اینکه ولیدیشن ها نوشته شده توسط برنامه نویس اعمال شود
                                     * options.DisableDataAnnotationsValidation = true;
                                     * به این شکل تتنظیم شود
                                     * 
                                     * 
                                     */
                                    options.DisableDataAnnotationsValidation = true;
                                    //options.AutomaticValidationEnabled = true;
                                    options.RegisterValidatorsFromAssemblies(new System.Reflection.Assembly[] 
                                    {
                                        typeof(GetPGravamenByIdRequestValidator).Assembly,
                                        typeof(GAttachmentContractValidator).Assembly
                                    });
                                  })
.AddJsonOptions(option =>
{
    option.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull | System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault;
});

builder.Services.AddScoped<ServiceModelValidationFilterAttribute>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "PunishmentOrgApi", Version = "v1" });
    options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
    {
        Description = "JWT Authorization header \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey
    });
    options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference { Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme, Id = "Bearer" }
            }, new List<string>()
        }
    });
});

builder.Services.AddSingleton<Microsoft.AspNetCore.Authorization.IAuthorizationHandler, Anu.PunishmentOrg.Api.Authentication.PermissionAuthorizationHandler>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Permission", policyBuilder =>
    {
        policyBuilder.Requirements.Add(new Anu.PunishmentOrg.Api.Authentication.PermissionAuthorizationRequirement());
    });
});

builder.Services.AddDbContext<Anu.DataAccess.ApplicationDbContext>(
                options =>
                {
                    var _dataBaseName = builder.Configuration.GetSection("ProductServer:dataBase").Value;

                    options.UseOracle(builder.Configuration.GetConnectionString(_dataBaseName), (oracleOptions) =>
                    {
                        oracleOptions.UseOracleSQLCompatibility("11");
                    }
                    );
                });
builder.Services.AddTransient(typeof(Anu.Domain.IGenericRepository<>), typeof(Anu.DataAccess.Repositories.GenericRepository<>));

builder.Services.AddTransient<Anu.DataAccess.IUnitOfWork, Anu.UnitOfWork.DataAccess.UnitOfWork>();
builder.Services.AddScoped<IDependencyResolver, DependencyResolver>();//(new DependencyResolver(builder.Services));
builder.Services.AddRepositories(
    typeof(Anu.BaseInfo.DataAccess.Unit.UnitRepository).Assembly,
    typeof(Anu.PunishmentOrg.DataAccess.DiscoveryMinutes.PChaseLicenseReqRepository).Assembly);

builder.Services.AddValidators(
    typeof(Anu.PunishmentOrg.Validation.Case.PCaseValidator).Assembly);



builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(option =>
{
    var key = System.Text.Encoding.ASCII.GetBytes(builder.Configuration.GetSection("JwtConfig:Secret").Value);
    option.SaveToken = true;
    option.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false, // for dev
        ValidateAudience = false, // for dev
        RequireExpirationTime = false, // for dev -- needs to be updated when refresh token is added
        ValidateLifetime = true
    };

    option.Events = new JwtBearerEvents
    {
        OnChallenge = async context =>
        {
            // Call this to skip the default logic and avoid using the default response
            context.HandleResponse();

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 401;
            //context.Response.Headers.Append("my-custom-header", "custom-value");
            var responseMessage = new Anu.Commons.ServiceModel.ServiceResponse.ResponseMessage()
            {
                Result = Anu.Commons.ServiceModel.ServiceResponseEnumerations.AnuResult.JwtTokenIsNotValid.GetResult()
            };
            string responseMessagestring = System.Text.Json.JsonSerializer.Serialize(responseMessage);
            await context.Response.WriteAsync(responseMessagestring);
        }
    };
});

builder.Host.ConfigureLogging((context, logging) =>
{
    logging.AddFileLogger(options =>
    {
        context.Configuration.GetSection("Logging").GetSection("File").GetSection("Options").Bind(options);
    });
});

//builder.Services.AddSession(session =>
//{
//    session.IdleTimeout = TimeSpan.FromMinutes(5);
//    session.Cookie.HttpOnly = true;
//});

var app = builder.Build();
SmsSender.GetConfiguration(app.Services.GetRequiredService<IConfiguration>());
ShahkarAuthentication.GetConfiguration(app.Services.GetRequiredService<IConfiguration>());
SabteahvalAuthentication.GetConfiguration(app.Services.GetRequiredService<IConfiguration>());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (!app.Environment.IsDevelopment())
{
    Stimulsoft.Base.StiLicense.Key = @"6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHn0s4gy0Fr5YoUZ9V00Y0igCSFQzwEqYBh/N77k4f0fWXTHW5rqeBNLkaurJDenJ9o97TyqHs9HfvINK18Uwzsc/bG01Rq+x3H3Rf+g7AY92gvWmp7VA2Uxa30Q97f61siWz2dE5kdBVcCnSFzC6awE74JzDcJMj8OuxplqB1CYcpoPcOjKy1PiATlC3UsBaLEXsok1xxtRMQ283r282tkh8XQitsxtTczAJBxijuJNfziYhci2jResWXK51ygOOEbVAxmpflujkJ8oEVHkOA/CjX6bGx05pNZ6oSIu9H8deF94MyqIwcdeirCe60GbIQByQtLimfxbIZnO35X3fs/94av0ODfELqrQEpLrpU6FNeHttvlMc5UVrT4K+8lPbqR8Hq0PFWmFrbVIYSi7tAVFMMe2D1C59NWyLu3AkrD3No7YhLVh7LV0Tttr/8FrcZ8xirBPcMZCIGrRIesrHxOsZH2V8t/t0GXCnLLAWX+TNvdNXkB8cF2y9ZXf1enI064yE5dwMs2fQ0yOUG/xornE";
}



app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseMiddleware<Anu.PunishmentOrg.Api.Authentication.ErrorHandlingMiddleware>();
//app.UseSession();

app.Run();
