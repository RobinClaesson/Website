# Website
The website contains a little information about me, and links to other sites where I exist. It also contains a list of the personal projects I have done or currently is working on.

It is built with Blazor WebAssembly using [Fluxor](https://github.com/mrpmorris/Fluxor), a zero boilerplate library for Redux development. Everything on the website is controlled by an imutable state, which state percists when changing pages on the site. The state can be altered by effects and reducers reacting to actions. Actions are fired by a lot of things, like clicking a button. This gives good control of the shifting content on the site, and allows for easier debugging as you step through actions and review the state.

## Dynamic Design
The layout of the elements on the site depends on the width of the window. If the width becomes small enough, a variable changes in the state, and the components change position to a more vertical layout.

## Themes
The website has several different selectable themes. Each component is built using color settings such as "Primary", "Secondaty", etc. What color is shown for each setting is determined by the current Fluxor-state.

The different selectable themes are loaded from a Json file and then populates the list of thems selectable in the settings in the lower right corner of the site. The intention is to later build a way to create personal custom themes that can be saved using local storage.