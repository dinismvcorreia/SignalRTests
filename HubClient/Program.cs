namespace HubClient
{
    using System;
    using Microsoft.AspNet.SignalR.Client;

    public class Program
    {
        static void Main()
        {
            const string url = @"http://localhost:8080/";

            var connection = new HubConnection(url);
            var hub = connection.CreateHubProxy("TestHub");
            connection.Start().Wait();

            hub.On("ReceiveLength", x => Console.WriteLine(x));

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                hub.Invoke("DetermineLength", line).Wait();
            }
        }
    }
}
