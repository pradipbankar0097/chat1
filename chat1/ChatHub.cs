using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/* changrs by yashashrre54456456*/

namespace chat1
{
    public class ChatHub : Hub
    {
        public void Send(string name,string message)
        {
            Clients.All.broadcastMessage(name,message);
        }
    }
}