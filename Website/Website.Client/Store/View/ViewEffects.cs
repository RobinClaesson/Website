using Fluxor;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using Website.Client.Design;

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
        public async Task OnViewPageInitAction(IDispatcher dispatcher)
        {
            var themeArray = await _httpClient.GetFromJsonAsync<WebThemeColors[]>("Themes/Default.json");
            var action = new ViewSetDefaultThemesAction(themeArray);
            dispatcher.Dispatch(action);
        }

    }
}
