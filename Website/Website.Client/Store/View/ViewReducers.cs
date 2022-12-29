using Fluxor;

namespace Website.Client.Store.View
{
    public class ViewReducers
    {
        [ReducerMethod]
        public static ViewState OnViewColorChangeAction(ViewState state, ViewColorChangeAction action)
        {
            return state with
            {
                Colors = action.Colors
            };
        }

    }
}
