using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxorPräsentation.Store
{
    public class ChatState
    {
        public ChatState()
        {
            if (Chatmessages == null)
            {
                Chatmessages = new List<string>();
            }
        }

       

        public ChatState(List<string> Chatmessages)
        {
            this.Chatmessages = Chatmessages;
        }

        public List<string> Chatmessages { get; }

      
    }
}
