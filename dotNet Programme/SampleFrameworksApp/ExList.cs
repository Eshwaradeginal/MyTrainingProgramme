using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SampleFrameworksApp
{
    class ExList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============List Example=========");
            List<string> lst = new List<string>();
            lst.Add("eshwar");
            lst.Add("appu");
            lst.Add("akash");
            lst.Add("ajay");
            lst.Add("power");
            lst.Remove("akash");
            Console.WriteLine(lst.IndexOf("eshwar"));
            lst.Insert(2,"rajakumara");
            Console.WriteLine(lst.GetType() );
            foreach (var movie in lst)
            {
                Console.WriteLine(movie);

            }

        }
    }
}
