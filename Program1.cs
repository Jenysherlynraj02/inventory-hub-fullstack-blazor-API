using InventoryHub.BlazorUI.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("https://localhost:5001/")
    });

builder.Services.AddScoped<InventoryService>();

await builder.Build().RunAsync();
