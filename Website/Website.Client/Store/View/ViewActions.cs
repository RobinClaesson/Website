using Website.Client.Models;

namespace Website.Client.Store.View
{
    public record ViewSetActiveThemeAction(WebThemeColors Theme);
    public record ViewSetLayoutSizeAction(LayoutSize LayoutSize);

    public record ViewPageInitAction();
    public record ViewSetDefaultThemesAction(WebThemeColors[] Themes);
    public record ViewSetProjectsAction(ProjectInfo[] Projects);

    public record ViewToggleProjectMenuAction();

}
