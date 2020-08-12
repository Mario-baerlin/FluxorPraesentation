using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxorPräsentation.Store.CounterUseCase
{
    public class SetCustomNumberAction
    {
        public SetCustomNumberAction(int customnumber)
        {
            CustomNumber = customnumber;
        }

        public int CustomNumber { get; set; }
    }
}
