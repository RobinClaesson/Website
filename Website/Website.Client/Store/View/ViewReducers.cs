using Fluxor;

namespace Website.Client.Store.View
{
    public class ViewReducers
    {
        [ReducerMethod]
        public static ViewState OnViewSetColorAction(ViewState state, ViewSetColorAction action)
        {
            return state with
            {
                Colors = action.Colors
            };
        }

    }
}
