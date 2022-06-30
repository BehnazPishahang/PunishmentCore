using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Anu.DataAccess.ApplicationDbContext>(
                options =>
                {
                    options.UseOracle("Password=ali;Persist Security Info=True;User ID=puo;Data Source=192.168.1.11/anu",(oracleOptions) => {
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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
