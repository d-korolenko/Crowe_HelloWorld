using System;

namespace HelloWorldAPI
{
    public class MessengerWebApp : IMessenger
    {
        public string GetMessage() => throw new NotImplementedException();
    }
}