using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxorPräsentation.Store.Chatroom
{
    public class AddChatMessage
    {
        public AddChatMessage(string message, List<string> messages)
        {
            Message = message;
            Messages = messages;
        }

        public string Message { get; set; }

        public List<string> Messages;

        public List<string> AddMessage()
        {
            Messages.Add(Message);
            return Messages;
        }
    }
}
