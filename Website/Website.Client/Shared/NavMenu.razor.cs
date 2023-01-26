using Website.Client.Models;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;

namespace Website.Client.Shared
{
    public partial class NavMenu
    {
        [Inject]
        public IDispatcher Dispatcher { get; set; }

        [Inject]
        public IState<ViewState> ViewState { get; set; }

        private bool _collapseNavMenu = true;
        private string? NavMenuCssClass => _collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            _collapseNavMenu = !_collapseNavMenu;
        }

        private void ToggleProjectMenu()
        {
            Dispatcher.Dispatch(new ViewToggleProjectMenuAction());
        }
    }
}
