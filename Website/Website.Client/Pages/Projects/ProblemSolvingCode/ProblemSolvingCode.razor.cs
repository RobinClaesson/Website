﻿using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Website.Client.Models;
using Website.Client.Services;
using Website.Client.Store.View;

namespace Website.Client.Pages.Projects.ProblemSolvingCode
{
    public partial class ProblemSolvingCode
    {
        [Inject]
        private IState<ViewState> ViewState { get; set; }

        [Inject]
        BrowserService BrowserService { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            BrowserService.Resize += (_, _) => StateHasChanged();
        }

    }
}
