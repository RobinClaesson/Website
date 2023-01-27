using Microsoft.AspNetCore.Components;

namespace Website.Client.Pages.Projects.SimulateFootball
{
    public partial class Statistic
    {
        [Parameter]
        public string Title { get; set; } = string.Empty;

        [Parameter]
        public string Description { get; set; } = string.Empty;
    }
}
