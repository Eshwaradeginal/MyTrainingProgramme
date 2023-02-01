using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp.Programs
{

    class totalNoOfDigit
    {
        public static void CountAll()
        {
            Console.WriteLine("Enter The String: ");
            string str = Console.ReadLine();
            int alphct = 0;
            int digtct = 0;
            //int eqlcnt = 0;
            int specialcnt = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                {
                    alphct++;
                }
                else if (str[i] >= 0 && str[i] <= 9)
                {
                    digtct++;
                }
                else
                {
                    specialcnt++;
                }

                // Console.WriteLine(str[i]);
            }
            Console.WriteLine("Alphabet count : " + alphct);
            Console.WriteLine(" digit count : " + digtct);
            Console.WriteLine("Special char : " + specialcnt);
        }
    }

    static void Main(string[] args)
    {
        CountAll();
    }

}
