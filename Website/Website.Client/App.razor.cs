using Blazorise;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Website.Client.Models;
using Website.Client.Services;
using Website.Client.Store.View;

namespace Website.Client
{
    public partial class App
    {
        private Theme theme = new Theme
        {
            ColorOptions = new ThemeColorOptions(),
            TextColorOptions = new ThemeTextColorOptions()
        };
    }
}
