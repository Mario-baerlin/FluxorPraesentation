using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxorPräsentation.Store.Chatroom
{
    public class ChatFeature : Feature<ChatState>
    {
        public override string GetName()
        {
            return "New Chat";
        }

        protected override ChatState GetInitialState()
        {
            return new ChatState();
        }
    }
}
