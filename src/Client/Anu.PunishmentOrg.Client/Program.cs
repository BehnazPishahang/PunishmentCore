using Anu.PunishmentOrg.Client;
using Anu.PunishmentOrg.Client.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.ManageIOC(builder.Configuration);

 
//AppConfiguration.Instance= builder.Configuration.GetSection(AppConfiguration.ConfigurationPosition).Get<AppConfiguration>();

//builder.Services.Configure<AppConfiguration>(Configuration.GetSection(AppConfiguration.ConfigurationPosition));

//builder.Services.Configure<AppConfiguration>(Configuration.GetSection("BackendSetting").Get<AppConfiguration>());


builder.Services.AddHttpClient();

builder.Services.AddMudServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
