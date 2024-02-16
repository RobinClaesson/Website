using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;

namespace Website.Client.Pages.Projects.TextShare;

public partial class TextShare
{
    [Inject]
    public IState<ViewState> ViewState { get; set; }

}
