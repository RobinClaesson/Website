using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;

namespace Website.Client.Pages.Projects.CommandLineMenu;

public partial class CommandLineMenu
{
    [Inject]
    IState<ViewState> ViewState { get; set; } = default!;
}
