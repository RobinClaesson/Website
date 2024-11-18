using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;

namespace Website.Client.Pages.Projects.Sudoku;

public partial class Sudoku
{
    [Inject]
    IState<ViewState> ViewState { get; set; }
}
