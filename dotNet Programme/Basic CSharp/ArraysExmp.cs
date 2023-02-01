using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    class ArraysExmp
    {
        static void Main(string[] args)
        {
        String[] ar = { "hai", "hello", "how", "are", "you" };
            Console.WriteLine("length of array : " + ar.Length);
            Console.WriteLine("length of dimension : " + ar.Rank);
            Console.WriteLine("items of array : " );
            foreach (string i in ar)
            {
             Console.WriteLine(i);

            }

        }
    }
}
