using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Ex01ArrayList
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("Apple");
            arr.Add("orrange");
            arr.Add("banana");
            arr.Add("starberry");
            arr.Add("butterfruit");
            arr.Remove("banana");
            arr.Insert(1, "grapes");
            arr.RemoveAt(3);
            Console.WriteLine("the total amount of fruits is : "+arr.Count);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
