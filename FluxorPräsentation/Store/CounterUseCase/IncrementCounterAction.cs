using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxorPräsentation.Store.CounterUseCase
{
    public class IncrementCounterAction
    {
        public IncrementCounterAction(int currentnumber)
        {
            CurrentNumber = currentnumber;
        }
        public int CurrentNumber;
        public int Increment()
        {
            return CurrentNumber + 1;
        }
    }
}
