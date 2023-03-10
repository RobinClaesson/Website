using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Website.Client.Models;
using Website.Client.Services;
using Website.Client.Store.View;

namespace Website.Client.Pages.Projects.MechanicalMoshpit
{
    public partial class MechanicalMoshpit
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

        private async Task Init()
        {
            BrowserService.Resize += HandleWindowResize;
            await BrowserService.Init(JSRuntime);
            BrowserService.SetLayoutThreshold(1200);

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
