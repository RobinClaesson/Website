﻿using Fluxor;
using Microsoft.AspNetCore.Components;
using Website.Client.Store.View;
using Website.Client.Design;

namespace Website.Client.Pages
{
    public partial class Index
    {
        [Inject]
        private IState<ViewState> ViewState { get; set; }

        
    }
}
