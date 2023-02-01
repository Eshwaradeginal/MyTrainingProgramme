using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SampleFrameworksApp
{

    class EXHashTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============HashTable Example=============");
            hashTableEXamle();

        }

        private static void hashTableEXamle()
        {
            try
            {

                Hashtable hash = new Hashtable();//stores key value pair data
                hash.Add("id", 3309);
                hash.Add("name", " Eshwar");
                foreach (DictionaryEntry item in hash)
                {
                    Console.WriteLine("{0}-{1}", item.Key, item.Value);
                }
            }catch(Exception ex)
            {

            throw new NotImplementedException();
            }
        }
    }
}
