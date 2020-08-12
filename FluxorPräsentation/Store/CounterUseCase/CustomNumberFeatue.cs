using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxorPräsentation.Store.CounterUseCase
{
    public class CustomNumberFeatue : Feature<CustomNumberState>
    {
        public override string GetName()
        {
            return "Hello world";
        }

        protected override CustomNumberState GetInitialState()
        {
            return new CustomNumberState();
        }
    }
}
