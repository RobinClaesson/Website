using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Website.Client;
using Fluxor;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;

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

//Blazorize
builder.Services
                .AddBlazorise(opt =>
                {
                    opt.Immediate = true;
                })
                .AddBootstrap5Providers()
                .AddFontAwesomeIcons();

//Run
await builder.Build().RunAsync();
