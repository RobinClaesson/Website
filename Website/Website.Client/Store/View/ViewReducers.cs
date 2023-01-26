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

        [ReducerMethod]
        public static ViewState OnViewSetProjectsAction(ViewState state, ViewSetProjectsAction action)
        {
            return state with
            {
                Projects = action.Projects
            };
        }

        [ReducerMethod(typeof(ViewToggleProjectMenuAction))]
        public static ViewState OnViewToggleProjectMenu(ViewState state)
        {
            return state with
            {
                OpenWindows = state.OpenWindows with
                {
                    ProjectMenu = !state.OpenWindows.ProjectMenu
                }
            };
        }
    }
}
