using System.Globalization;

namespace ConsoleApp1
{
    public static class Program
    {
        private static readonly Task Task = new(() => { });

        private static readonly Action Action = () => { };
        public static void Main(string[] args)
        {
            Action();
            Person b = new Person();
            Console.WriteLine("Hello, World!");
            HttpMessageHandler;
        }
    }

    public abstract class Person
    {
        public int Id { get; set; }

        public virtual void Go()
        {

        }

        public abstract void Do();
    }
}

