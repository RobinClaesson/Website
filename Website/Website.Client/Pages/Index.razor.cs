using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;
using Website.Client.Models;

namespace Website.Client.Pages
{
    public partial class Index
    {
        [Inject]
        private IState<ViewState> ViewState { get; set; }

        
    }
}
