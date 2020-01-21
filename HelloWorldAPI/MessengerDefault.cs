using System;

namespace HelloWorldAPI
{
    public class MessengerDefault: IMessenger
    {
        public string GetMessage() => "DEFAULT: Hello World!";
    }
}