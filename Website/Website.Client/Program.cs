using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Website.Client;
using Fluxor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//Services
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Fluxor
var currentAssembly = typeof(Program).Assembly;
builder.Services.AddFluxor(opt => {
    opt.ScanAssemblies(currentAssembly);
#if DEBUG
    opt.UseReduxDevTools();
#endif
});

//Run
await builder.Build().RunAsync();
