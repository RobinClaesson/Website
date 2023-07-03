using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Website.Client.Models;
using Website.Client.Services;
using Website.Client.Store.View;

namespace Website.Client.Shared
{
    public partial class WindowResizeHandlerComponent
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        [Inject]
        BrowserService BrowserService { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            InitWindowResizeHandling().GetAwaiter();
        }

        private async Task InitWindowResizeHandling()
        {
            BrowserService.Resize += HandleWindowResize;
            await BrowserService.Init(JSRuntime);
            BrowserService.SetLayoutThreshold(1250);

            //This delay is needed so that the state gets updated if 
            //the window is below the threshold.
            await Task.Delay(100);
            StateHasChanged();
        }

        private void HandleWindowResize(object sender, LayoutSize layoutSize)
        {
            Dispatcher.Dispatch(new ViewSetLayoutSizeAction(layoutSize));
            StateHasChanged();
        }
    }
}
