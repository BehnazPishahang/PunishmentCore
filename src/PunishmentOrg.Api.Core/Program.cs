//using Anu.PunishmentOrg.Api.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.Swagger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    //var policy = new Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    //options.Filters.Add(new Microsoft.AspNetCore.Mvc.Authorization.AuthorizeFilter(policy));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "PunishmentOrgApi", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
    {
        Description = "JWT Authorization header \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey
    });
    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference { Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme, Id = "Bearer" }
            }, new List<string>() }
    });
});

//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("Manage",
//        policyBuilder =>
//            policyBuilder.AddRequirements(
//                //new Anu.PunishmentOrg.Api.Authentication.IsAccountEnabledRequirement(),
//                //new Anu.PunishmentOrg.Api.Authentication.IsAllowedToManageProductRequirement()
//                //new Anu.PunishmentOrg.Api.Authentication.MinimumAgeRequirement("All")
//                new Anu.PunishmentOrg.Api.Authentication.PermissionRequirement("")
//            ));
//});

//builder.Services.AddSingleton<Microsoft.AspNetCore.Authorization.IAuthorizationHandler, Anu.PunishmentOrg.Api.Authentication.IsAccountNotDisabledHandler>();
//builder.Services.AddSingleton<Microsoft.AspNetCore.Authorization.IAuthorizationHandler, Anu.PunishmentOrg.Api.Authentication.IsEmployeeHandler>();
//builder.Services.AddSingleton<Microsoft.AspNetCore.Authorization.IAuthorizationHandler, Anu.PunishmentOrg.Api.Authentication.IsVIPCustomerHandler>();


//builder.Services.AddAuthorization(options =>
//{
//    foreach (var criterion in Anu.PunishmentOrg.Api.Authentication.PrincipalPermission.Criteria)
//    {
//        options.AddPolicy(criterion.Method.Name, policy => policy.RequireAssertion(criterion));
//    }
//});

//builder.Services.AddAuthorization(config =>
//{
//    config.AddPolicy("AccessPolicy", policyBuilder =>
//    {
//        //policyBuilder.UserRequireCustomClaim(ClaimTypes.Email);
//        //policyBuilder.UserRequireCustomClaim(ClaimTypes.DateOfBirth);
//        new Anu.PunishmentOrg.Api.Authentication.PoliciesAuthorizationHandler();
//    });
//});

//builder.Services.AddScoped<Microsoft.AspNetCore.Authorization.IAuthorizationHandler, Anu.PunishmentOrg.Api.Authentication.PoliciesAuthorizationHandler>();
////builder.Services.AddScoped<Microsoft.AspNetCore.Authorization.IAuthorizationHandler, RolesAuthorizationHandler>();


//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
//});

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
                    options.UseOracle("Password=ali;Persist Security Info=True;User ID=puo;Data Source=192.168.1.11/anu", (oracleOptions) =>
                    {
                        oracleOptions.UseOracleSQLCompatibility("11");
                    }
                    );
                });
#region Repositories
builder.Services.AddTransient(typeof(Anu.Domain.IGenericRepository<>), typeof(Anu.DataAccess.Repositories.GenericRepository<>));
#endregion
#region UnitOfWork
builder.Services.AddTransient<Anu.DataAccess.IUnitOfWork, Anu.UnitOfWork.DataAccess.UnitOfWork>();
#endregion

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    //[Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
})
.AddJwtBearer(jwt =>
{
    var key = System.Text.Encoding.ASCII.GetBytes(builder.Configuration.GetSection("JwtConfig:Secret").Value);
    jwt.SaveToken = true;
    jwt.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false, // for dev
        ValidateAudience = false, // for dev
        RequireExpirationTime = false, // for dev -- needs to be updated when refresh token is added
        ValidateLifetime = true
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
