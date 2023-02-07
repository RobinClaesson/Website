using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;
using Website.Client.Models;
using Website.Client.Services;
using Microsoft.JSInterop;

namespace Website.Client.Pages
{
    public partial class Index
    {
        [Inject]
        private IState<ViewState> ViewState { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        [Inject]
        BrowserService BrowserService { get; set; }


        protected override void OnInitialized()
        {
            base.OnInitialized();
            Init().GetAwaiter();
        }

        //TODO: This should somehow be put into a single function and not copied like now, might not be possible because the StateHasChanged Call
        private async Task Init()
        {
            BrowserService.Resize += HandleWindowResize;
            await BrowserService.Init(JSRuntime);
            BrowserService.SetLayoutThreshold(1100);

            //This delay is needed so that the state gets updated if 
            //the window is below the threshold. Not an optimal way
            //to solve it, but it's the only thing that have worked.
            await Task.Delay(10);
            StateHasChanged();
        }

        private void HandleWindowResize(object sender, LayoutSize layoutSize)
        {
            Dispatcher.Dispatch(new ViewSetLayoutSizeAction(layoutSize));
            StateHasChanged();
        }

    }
}
