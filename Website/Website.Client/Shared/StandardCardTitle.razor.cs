using Website.Client.Models;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;
using Blazorise;

namespace Website.Client.Shared
{
    public partial class StandardCardTitle
    {
        [Parameter] 
        public string Title { get; set; } = string.Empty;

        [Parameter]
        public TextColor TitleColor { get; set; } = TextColor.Info;
    }
}
