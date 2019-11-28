using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace signalrmvc5
{
    public class ChatHub:Hub
    {
        public void SendToAll(string name,string message)
        {
            Clients.All.addnewmessage(name, message);
        }
        public void SendToOne(string name,string message,string id)
        {
            Clients.Client(id).addnewmessage(name, message);
        }
    }
}