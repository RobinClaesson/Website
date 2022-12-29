﻿using Website.Client.Design;
using Fluxor;

namespace Website.Client.Store.View
{
    [FeatureState]
    public record ViewState
    {
        public WebsiteColors Colors { get; set; } = WebsiteColors.DarkGreen;

        private ViewState() { }
        public ViewState(WebsiteColors colors)
        {
            Colors = colors;
        }
    }
}