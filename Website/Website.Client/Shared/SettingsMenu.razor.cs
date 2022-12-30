using Microsoft.AspNetCore.Components;
using Fluxor;
using Blazorise;
using Website.Client.Store.View;
using Website.Client.Design;

namespace Website.Client.Shared
{
    public partial class SettingsMenu
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

        public void SetThemeColors(WebThemeColors colors)
        {
            Dispatcher.Dispatch(new ViewSetColorAction(colors));
            UpdateTheme();
        }

        public void UpdateTheme()
        {
            Theme.ColorOptions = new ThemeColorOptions
            {
                Primary = ViewState.Value.Colors.Primary,
                Secondary = ViewState.Value.Colors.Secondary,
                Dark = ViewState.Value.Colors.Dark,
                Light = ViewState.Value.Colors.Light
            };

            Theme.TextColorOptions = new ThemeTextColorOptions
            {
                Primary = ViewState.Value.Colors.TextPrimary,
                Secondary = ViewState.Value.Colors.TextSecondary,
                Info = ViewState.Value.Colors.TextHighlight
            };

            Theme.ThemeHasChanged();
        }
    }
}
