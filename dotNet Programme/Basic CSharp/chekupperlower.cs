using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp.Programs
{
    class chekupperlower
    {
        public static void Convertcase()
        {
            Console.WriteLine("Enter any String");
            var str1 = Console.ReadLine();

            char[] arr1 = str1.ToCharArray(0, str1.Length); ;

            char ch;
            for (int i = 0; i < str1.Length; i++)
            {
                if (Char.IsLower(arr1[i]))
                    Console.Write(Char.ToUpper(arr1[i]));
                else
                    Console.Write(Char.ToLower(arr1[i]));
            }
            Console.Write("\n");

        }
        static void Main(string[] args)
        {
            Convertcase();

           

        }
    }
}
