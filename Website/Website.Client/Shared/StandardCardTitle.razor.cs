using Website.Client.Models;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;

namespace Website.Client.Shared
{
    public partial class StandardCardTitle
    {
        [Parameter] 
        public string Title { get; set; } = string.Empty;
    }
}
