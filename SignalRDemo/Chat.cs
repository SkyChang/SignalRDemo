using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SignalRDemo
{
    public class Chat : Hub//PersistentConnection
    {
        /*
        protected override Task OnReceivedAsync(IRequest request, string connectionId, string data)
        {
            // Broadcast data to all clients
            return Connection.Broadcast(data);
        }*/

        
        // client 端透過 proxy object ，直接呼叫這個方法。
        public void Send(string message)
        {
            // Call the addMessage method on all clients     
            //Clients代表所有有使用 Chat 的頁面，而
            //addMessage 方法，就代表 server 端呼叫 Clients 上的JavaScript 的方法。
            Clients.All.addMessage(message);
        }
    }
}