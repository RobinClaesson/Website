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

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        [CascadingParameter] Theme Theme { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            UpdateTheme();
        }

        public void SetThemeColors()
        {
            Dispatcher.Dispatch(new ViewColorChangeAction(new WebsiteColors()));
            UpdateTheme();
        }

        public void UpdateTheme()
        {
            Theme.ColorOptions = new ThemeColorOptions
            {
                Primary = ViewState.Value.Colors.PrimaryHtml,
                Secondary = ViewState.Value.Colors.SecondaryHtml
            };

            Theme.TextColorOptions = new ThemeTextColorOptions
            {
                Primary = ViewState.Value.Colors.TextPrimaryHtml,
                Secondary = ViewState.Value.Colors.TextSecondaryHtml
            };

            Theme.ThemeHasChanged();
        }
    }
}
