using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxorPräsentation.Store.CounterUseCase
{
    public class CustomNumberState
    {
		public int CustomNumber { get; }

		public CustomNumberState( int customNumber)
		{			
			CustomNumber = customNumber;
		}

        public CustomNumberState()
        {
        }
    }
}
