using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxorPräsentation.Store.CounterUseCase
{
    public class IncrementCounterReducer
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action)
        {
            return new CounterState(clickCount: action.Increment());
            //return new CounterState(clickCount: state.ClickCount + 1)
        }

        [ReducerMethod]
        public static CustomNumberState ReduceSetCustomNumberAction(CustomNumberState state, SetCustomNumberAction action)
        {
            return new CustomNumberState(customNumber: action.CustomNumber);
            //return new CounterState(clickCount: state.ClickCount + 1)
        }

    }
}
