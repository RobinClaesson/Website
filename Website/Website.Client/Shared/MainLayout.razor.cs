using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Design;
using Website.Client.Store.View;

using Blazorise;

namespace Website.Client.Shared
{
    public partial class MainLayout
    {
        [Inject]
        private IState<ViewState> ViewState { get; set; }

    }
}
