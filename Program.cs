using CautionSououmission.Shared;
using Crudblazorserve2;
using Crudblazorserve2.Services;
using FastReport.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using System.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(Options =>
{
    Options.UseNpgsql(builder.Configuration.GetConnectionString("DefaulConnection"));
});


//connexion fastreport
FastReport.Utils.RegisteredObjects.AddConnection(typeof(JsonDataConnection));

builder.Services.AddTransient<BeneficiaireService>();
builder.Services.AddTransient<CautionService>();
builder.Services.AddTransient<TypearticleService>();
builder.Services.AddTransient<DonneurordreService>();
builder.Services.AddMudServices();





// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

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
