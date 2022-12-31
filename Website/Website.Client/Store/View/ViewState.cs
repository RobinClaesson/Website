using Website.Client.Design;
using Fluxor;

namespace Website.Client.Store.View
{
    [FeatureState]
    public record ViewState
    {
        public WebThemeColors[] DefaultThemes { get; set; } = new WebThemeColors[0];
        public WebThemeColors ActiveTheme { get; set; } = new WebThemeColors();
        public OpenWindows OpenWindows { get; set; } = new OpenWindows();

        private ViewState() { }
        public ViewState(WebThemeColors[] defaultThemes, WebThemeColors activeTheme, OpenWindows openWindows)
        {
            DefaultThemes = defaultThemes;
            ActiveTheme = activeTheme;
            OpenWindows = openWindows;
        }
    }

    public record OpenWindows
    {
    }
}
