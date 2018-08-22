using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageFactory = new MessageFactory() as IFactory;
            var minifactory1 = messageFactory.GetMessage("Mini Factory");
            var minifactory2 = messageFactory.GetMessage(string.Empty);
        }
    }

    public interface IFactory
    {
        IMiniFactory GetMessage(string message);
    }

    public class MessageFactory : IFactory
    {
        public IMiniFactory GetMessage(string message)
        {
            if(!string.IsNullOrEmpty(message))
            {
                return new MiniFactory1();
            }
            else
            {
                return new MiniFactory2();
            }
        }
    }

    public interface IMiniFactory
    {
       string MiniMessage { get; set; }
    }

    public class MiniFactory1 : IMiniFactory
    {
        public string MiniMessage { get; set; }
    }

    public class MiniFactory2 : IMiniFactory
    {
        public string MiniMessage { get; set; }
    }
}
