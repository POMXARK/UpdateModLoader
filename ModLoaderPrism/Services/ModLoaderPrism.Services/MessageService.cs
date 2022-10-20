using ModLoaderPrism.Services.Interfaces;

namespace ModLoaderPrism.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
