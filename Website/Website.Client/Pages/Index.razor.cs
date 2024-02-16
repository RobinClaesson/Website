using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;
using Website.Client.Models;
using Website.Client.Services;
using Microsoft.JSInterop;
using Website.Client.Shared;

namespace Website.Client.Pages
{
    public partial class Index
    {
        [Inject]
        private IState<ViewState> ViewState { get; set; }

    }
}
