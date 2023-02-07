using Microsoft.AspNetCore.Components;
using Website.Client.Services;

namespace Website.Client.Pages.Projects.Eportfolio
{
    public partial class EPortfolio
    {
        [Inject]
        BrowserService BrowserService { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            BrowserService.SetLayoutThreshold(700);
        }
    }
}
