using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = new Singleton();
            var policy1 = singleton.GetPolicy();
            var policy2 = singleton.GetPolicy();
            if(policy1 == policy2)
            {
                Console.WriteLine("Singleton Object Created");
            }
        }
    }

    public class Singleton
    {
        private static readonly Policy _Policy = new Policy();
        public Policy GetPolicy()
        {
            return _Policy;
        }
    }

    public class Policy
    {
        public string Name { get; set; }
    }
}
