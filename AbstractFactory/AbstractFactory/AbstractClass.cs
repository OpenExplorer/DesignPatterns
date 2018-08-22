using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractClass
    { 
        public abstract IMessage1 GetMessage1();
        public abstract IMessage2 GetMessage2();
    }

    public interface IMessage1
    {
       string GetMessage(string input);
    }

    public interface IMessage2
    {
        string GetMessage(string input);
    }

    public class Message1 : IMessage1
    {
        public string GetMessage(string input)
        {
            return input;
        }
    }

    public class Message2 : IMessage2
    {
        public string GetMessage(string input)
        {
            return input;
        }
    }

    public class DerivedClass : AbstractClass
    {
        public override IMessage1 GetMessage1()
        {
            return new Message1();
        }

        public override IMessage2 GetMessage2()
        {
            return new Message2();
        }
    }
}
