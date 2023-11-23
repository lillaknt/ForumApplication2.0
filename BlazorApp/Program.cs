using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp;
using HttpClients.ClientInterfaces;
using HttpClients.Implementation;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("https://localhost:7199") 
    });

builder.Services.AddScoped<IUserService, UserHttpClient>();
builder.Services.AddScoped<IPostService, PostHttpClient>();




await builder.Build().RunAsync();