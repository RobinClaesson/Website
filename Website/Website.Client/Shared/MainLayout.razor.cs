using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Design;
using Website.Client.Store.View;

namespace Website.Client.Shared
{
    public partial class MainLayout
    {
        [Inject]
        private IState<ViewState> ViewState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        public void ChangeCollorButtonPress()
        {
            Dispatcher.Dispatch(new ViewColorChangeAction(new WebsiteColors()));
        }
    }
}
