using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Models;
using Website.Client.Store.View;

using Blazorise;
using Website.Client.Services;
using Microsoft.JSInterop;

namespace Website.Client.Shared
{
    public partial class MainLayout
    {
        [Inject]
        public IState<ViewState> ViewState { get; set; }
    }

}
