using BlazorWeb;
using BlazorWeb.Interfaces;
using BlazorWeb.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<ICompetitionService, CompetitionService>();
//builder.Services.AddSingleton<ICompetitionService, CompetitionService>();

var app = builder.Build();

//var service = app.Services.GetRequiredService<ICompetitionService>();

//await service.InitializeAsync();

await app.RunAsync();
