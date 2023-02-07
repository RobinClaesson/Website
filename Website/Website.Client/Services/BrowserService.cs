using Blazorise;
using Fluxor;
using Microsoft.JSInterop;
using Website.Client.Models;
using Website.Client.Store.View;

namespace Website.Client.Services
{
    public class BrowserService
    {
        public int LayoutThreshold { get; private set; } = 1000;

        private IJSRuntime _jsRuntime = null;

        public event EventHandler<LayoutSize> Resize;
        private BrowserDimension _dimensions = null;
        private LayoutSize _currentLayout = LayoutSize.Large;


        public async Task Init(IJSRuntime js)
        {
            // enforce single invocation            
            if (_jsRuntime == null)
            {
                this._jsRuntime = js;
                await _jsRuntime.InvokeAsync<string>("resizeListener", DotNetObjectReference.Create(this));
                await GetDimensions();
                CheckLayout();
            }
        }

        [JSInvokable]
        public void SetBrowserDimensions(int jsBrowserWidth, int jsBrowserHeight)
        {
            _dimensions.Width = jsBrowserWidth;
            _dimensions.Height = jsBrowserHeight;
            CheckLayout();
        }

        private void CheckLayout()
        {
            if (_currentLayout == LayoutSize.Large)
            {
                if (_dimensions.Width < LayoutThreshold)
                {
                    this.Resize?.Invoke(this, LayoutSize.Small);
                    _currentLayout = LayoutSize.Small;
                }
            }

            else
            {
                if (_dimensions.Width > LayoutThreshold)
                {
                    this.Resize?.Invoke(this, LayoutSize.Large);
                    _currentLayout = LayoutSize.Large;
                }
            }
        }

        public void SetLayoutThreshold(int threshold)
        {
            LayoutThreshold = threshold;
            CheckLayout();
        }

        private async Task GetDimensions()
        {
            _dimensions = await _jsRuntime.InvokeAsync<BrowserDimension>("getDimensions");
        }

        private class BrowserDimension
        {
            public int Width { get; set; }
            public int Height { get; set; }
        }
    }
}
