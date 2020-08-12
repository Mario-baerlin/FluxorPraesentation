using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxorPräsentation.Store.Chatroom
{
    public class ChatReducer
    {
        [ReducerMethod]
        public static ChatState AddMessageAction(ChatState state, AddChatMessage action)
        {
            return new ChatState(Chatmessages: action.AddMessage());
            //return new CounterState(clickCount: state.ClickCount + 1)
        }
    }
}
