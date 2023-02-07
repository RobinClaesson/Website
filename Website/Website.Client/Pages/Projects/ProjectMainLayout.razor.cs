using Website.Client.Models;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;
using Website.Client.Services;

namespace Website.Client.Pages.Projects
{
    public partial class ProjectMainLayout
    {
        [Parameter]
        public string Title { get; set; } = string.Empty;

        [Parameter]
        public string GithubLink { get; set; } = string.Empty;
    }
}
