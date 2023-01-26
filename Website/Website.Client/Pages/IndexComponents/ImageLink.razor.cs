using Website.Client.Models;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;

namespace Website.Client.Pages.IndexComponents
{
    public partial class ImageLink
    {
        [Parameter]
        public string Image { get; set; } = string.Empty;

        [Parameter]
        public string Title { get; set; } = string.Empty;

        [Parameter]
        public string Link { get; set; } = string.Empty;
    }
}
