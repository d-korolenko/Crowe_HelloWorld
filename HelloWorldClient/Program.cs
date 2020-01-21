using System;
using System.IO;
using System.Linq;
using HelloWorldAPI;
using Microsoft.Extensions.Configuration;

namespace HelloWorldMain
{
    class Program
    {

        static void Main(string[] args)
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            IMessenger messenger = GetMessenger(configuration["messenger"]);
            Console.WriteLine(messenger.GetMessage());

        }
        static IMessenger GetMessenger(string messenger)
        {
            switch (messenger)
            {
                case "Console":
                    return new MessengerConsole();
                case "DB":
                    return new MessengerDB();
                case "Mobile":
                    return new MessengerMobile();
                case "WebApp":
                    return new MessengerWebApp();
                case "WinService":
                    return new MessengerWinService();
                default:
                    return new MessengerDefault();
            }
        }
    }
}
