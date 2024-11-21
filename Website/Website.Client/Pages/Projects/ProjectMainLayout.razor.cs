using Microsoft.AspNetCore.Components;

namespace Website.Client.Pages.Projects
{
    public partial class ProjectMainLayout
    {
        [Parameter]
        public string Title { get; set; } = string.Empty;

        [Parameter]
        public string GithubLink { get; set; } = string.Empty;

        [Parameter]
        public string PackageName { get; set; } = string.Empty;

        private string NuGetLink()
            => $"https://www.nuget.org/packages/{PackageName}";

        private string NuGetImage()
            => $"https://img.shields.io/nuget/v/{PackageName}";
    }
}
