using Website.Client.Models;
using Fluxor;

namespace Website.Client.Store.View
{
    [FeatureState]
    public record ViewState
    {
        public WebThemeColors[] DefaultThemes { get; set; } = new WebThemeColors[0];
        public WebThemeColors ActiveTheme { get; set; } = new WebThemeColors();
        public OpenWindows OpenWindows { get; set; } = new OpenWindows();
        public ProjectInfo[] Projects { get; set; } = new ProjectInfo[0];
        public LayoutSize LayoutSize { get; set; } = LayoutSize.Large;

        private ViewState() { }
        public ViewState(WebThemeColors[] defaultThemes, WebThemeColors activeTheme, OpenWindows openWindows, ProjectInfo[] projects, LayoutSize layoutSize)
        {
            DefaultThemes = defaultThemes;
            ActiveTheme = activeTheme;
            OpenWindows = openWindows;
            Projects = projects;
            LayoutSize = layoutSize;
        }
    }

    public record OpenWindows
    {
        public bool ProjectMenu { get; set; } = true;
    }
}
