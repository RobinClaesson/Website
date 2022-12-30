using Website.Client.Design;
using Fluxor;
using Blazorise;

namespace Website.Client.Store.View
{
    [FeatureState]
    public record ViewState
    {
        public Design.WebThemeColors Colors { get; set; } = Design.WebThemeColors.DarkTheme;
        public OpenWindows OpenWindows { get; set; } = new OpenWindows();

        private ViewState() { }
        public ViewState(Design.WebThemeColors colors, OpenWindows openWindows)
        {
            Colors = colors;
            OpenWindows = openWindows;
        }
    }

    public record OpenWindows
    {
    }
}
