namespace Hub
{
    using System;
    using Microsoft.Owin.Hosting;

    internal class Program
    {
        private static void Main()
        {
            const string url = "http://localhost:8080/";

            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine($"Server running at {url}");
                Console.ReadLine();
            }
        }
    }
}
