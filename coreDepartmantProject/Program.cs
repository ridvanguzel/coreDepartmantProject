using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Configuration;
using System.Net.NetworkInformation;
using System.Text.Json;






var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Authenticon�n Kodu bu �ekilde program.cs de ekleniyor. Ekleyece�imiz kodlar� buraya yerle�tiriyoruz
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
{
	x.LoginPath = "/Login/LoginPage";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();
// bunu da ekledik yukar�daki kodu eklerken

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=departmant}/{action=depart}/{id?}");

app.Run();
