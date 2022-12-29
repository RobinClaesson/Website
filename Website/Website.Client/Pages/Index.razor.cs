using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;
using Website.Client.Design;

namespace Website.Client.Pages
{
    public partial class Index
    {
        [Inject]
        private IState<ViewState> ViewState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }


        public void ChangeCollorButtonPress()
        {
            Dispatcher.Dispatch(new ViewColorChangeAction( new WebsiteColors()));
        }
    }
}
