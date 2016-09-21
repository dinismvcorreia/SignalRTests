namespace Hub
{
    using System;
    using Microsoft.AspNet.SignalR;
    using Microsoft.AspNet.SignalR.Hubs;

    [HubName("TestHub")]
    public class TestHub : Hub
    {
        public void DetermineLength(string message)
        {
            Console.WriteLine(message);
            var newMessage = string.Format($"{message} has a length of: {message.Length}");
            Clients.All.ReceiveLength(newMessage);
        }
    }
}
