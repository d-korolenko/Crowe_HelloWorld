using System;

namespace HelloWorldAPI
{
    public class MessengerConsole : IMessenger
    {
        public string GetMessage() => "CONSOLE: Hello World!";
    }
}