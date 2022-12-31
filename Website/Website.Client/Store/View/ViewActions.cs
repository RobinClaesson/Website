using Website.Client.Design;

namespace Website.Client.Store.View
{
    public record ViewSetActiveThemeAction(WebThemeColors Theme);

    public record ViewPageInitAction();
    public record ViewSetDefaultThemesAction(WebThemeColors[] Themes);
}
