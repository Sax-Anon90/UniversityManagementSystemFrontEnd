using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using UniversityManagementSystem.BlazorWASM.Client;
using UniversityManagementSystem.BlazorWASM.Client.Providers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddRadzenComponents();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddTransient<CustomAuthenticationStateProvider>();
builder.Services.AddTransient<AuthenticationStateProvider>(x => x.GetRequiredService<CustomAuthenticationStateProvider>());


await builder.Build().RunAsync();

