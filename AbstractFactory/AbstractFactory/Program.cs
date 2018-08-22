using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClass = new DerivedClass();

            IMessage1 message1 = abstractClass.GetMessage1();
            var msgString1 = message1.GetMessage("Hello Message1");

            IMessage2 message2 = abstractClass.GetMessage2();
            var msgString2 = message2.GetMessage("Hello Message2");
        }
    }
}
