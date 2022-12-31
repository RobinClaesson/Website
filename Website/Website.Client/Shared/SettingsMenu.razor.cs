using Microsoft.AspNetCore.Components;
using Fluxor;
using Blazorise;
using Website.Client.Store.View;
using Website.Client.Design;
using Newtonsoft.Json;

namespace Website.Client.Shared
{
    public partial class SettingsMenu
    {
        [Inject]
        private IState<ViewState> ViewState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        [Inject]
        public IActionSubscriber ActionSubscriber { get; set; }

        [CascadingParameter]
        Theme Theme { get; set; }

        protected override void OnInitialized()
        {
            //Update once on init to get the default colors set (Prevents starting with full white screen)
            UpdateTheme();
            //Subscribe to when the json is loaded to update again
            ActionSubscriber.SubscribeToAction<ViewSetDefaultThemesAction>(this, (action) => UpdateTheme());

            Dispatcher.Dispatch(new ViewPageInitAction());
            base.OnInitialized();
        }

        public void SetThemeColors(WebThemeColors theme)
        {
            Dispatcher.Dispatch(new ViewSetActiveThemeAction(theme));
            UpdateTheme();
        }

        public void UpdateTheme()
        {
            Theme.ColorOptions = new ThemeColorOptions
            {
                Primary = ViewState.Value.ActiveTheme.Primary,
                Secondary = ViewState.Value.ActiveTheme.Secondary,
                Dark = ViewState.Value.ActiveTheme.Dark,
                Light = ViewState.Value.ActiveTheme.Light
                
            };

            Theme.TextColorOptions = new ThemeTextColorOptions
            {
                Primary = ViewState.Value.ActiveTheme.TextPrimary,
                Secondary = ViewState.Value.ActiveTheme.TextSecondary,
                Info = ViewState.Value.ActiveTheme.TextInfo,

                //Used for arrows on dropdown menues
                Dark = ViewState.Value.ActiveTheme.Dark
            };

            Theme.BackgroundOptions = new ThemeBackgroundOptions
            {
                Primary = ViewState.Value.ActiveTheme.Primary,
                Secondary = ViewState.Value.ActiveTheme.Secondary,
                Dark = ViewState.Value.ActiveTheme.Dark,
                Light = ViewState.Value.ActiveTheme.Light
            };

            Theme.ThemeHasChanged();
        }
    }
}
