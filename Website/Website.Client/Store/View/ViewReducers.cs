using Fluxor;

namespace Website.Client.Store.View
{
    public class ViewReducers
    {
        [ReducerMethod]
        public static ViewState OnViewSetActiveThemeAction(ViewState state, ViewSetActiveThemeAction action)
        {
            return state with
            {
                ActiveTheme = action.Theme
            };
        }

        [ReducerMethod]
        public static ViewState OnViewSetDefaultThemesAction(ViewState state, ViewSetDefaultThemesAction action)
        {
            if (action.Themes.Length > 0)
            {
                return state with
                {
                    DefaultThemes = action.Themes,
                    ActiveTheme = action.Themes[0]
                };
            }
            else return state;
        }
    }
}
