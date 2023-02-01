using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    class Example
    {
        internal static int value;
        public Example() => Console.WriteLine("Instance Constructor");

        static Example()
        {
            value = 1000;
            Console.WriteLine("Static Constructor");
        }
    }
    static class SingletonClass
    {
        public static void StaticMethod() => Console.WriteLine("Static method called");
    }

    class staticExample
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            ex = new Example(); ex = new Example(); ex = new Example();
            Example.value=220020;

        }
    }
}
