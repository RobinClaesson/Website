using Website.Client.Models;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;

namespace Website.Client.Pages.Projects
{
    public partial class ProjectMailLayout
    {
        [Parameter]
        public string Title { get; set; } = string.Empty;

        [Parameter]
        public string GithubLink { get; set; } = string.Empty;
    }
}
