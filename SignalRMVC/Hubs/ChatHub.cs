using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRMVC.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message, string Latitude, string Longitude)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.Others.addNewMessageToPage(name, message, Latitude, Longitude);
        }
    }
}