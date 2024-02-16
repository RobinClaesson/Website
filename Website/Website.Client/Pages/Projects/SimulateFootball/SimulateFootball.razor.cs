using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Website.Client.Models;
using Website.Client.Services;
using Website.Client.Store.View;

namespace Website.Client.Pages.Projects.SimulateFootball
{
    public partial class SimulateFootball
    {
        [Inject]
        private IState<ViewState> ViewState { get; set; }

    }
}
