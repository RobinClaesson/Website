using Fluxor;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using Website.Client.Models;

namespace Website.Client.Store.View
{
    public class ViewEffects
    {
        private readonly HttpClient _httpClient;

        public ViewEffects(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [EffectMethod(typeof(ViewPageInitAction))]
        public async Task OnViewPageInitAction_GetThemes(IDispatcher dispatcher)
        {
            var themeArray = await _httpClient.GetFromJsonAsync<WebThemeColors[]>("Themes/Default.json");
            var action = new ViewSetDefaultThemesAction(themeArray);
            dispatcher.Dispatch(action);
        }

        [EffectMethod(typeof(ViewPageInitAction))]
        public async Task OnViewPageInitAction_GetProjects(IDispatcher dispatcher)
        {
            var projectArray = await _httpClient.GetFromJsonAsync<ProjectInfo[]>("Projects.json");
            var action = new ViewSetProjectsAction(projectArray);
            dispatcher.Dispatch(action);
        }

    }
}
