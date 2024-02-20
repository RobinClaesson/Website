using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;

namespace Website.Client.Pages.Projects.RubiksCube;

public partial class RubiksCube
{
    [Inject]
    IState<ViewState> ViewState { get; set; }
}
