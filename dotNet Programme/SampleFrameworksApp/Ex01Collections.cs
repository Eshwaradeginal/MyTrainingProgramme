using System;
using System.Collections;
/*
 * Collections are a bunch of classes created to resolve the issues with Arrays. 
 * All the limitations of the Arrays are resolved using the Collection Classes. 
 * Collection classes are available in 2 variations: Generic and NonGeneric. 
 * NonGeneric are the oldest form of collections, almost obselete but is still available in the .NET Frameworks for backward compatibility and certain scenarios. 
 * Generics came in .NET 2.0.(2005).
 * System.Collections is the namespace for the classes related to Non Generic Collections.
 */
namespace SampleFrameworksApp
{
    class Ex01Collections
    {
        static void Main(string[] args)
        {
            arrayListExample();
        }

        private static void arrayListExample()
        {
            ArrayList list = new ArrayList();//blank list of items. 
            list.Add("Apples");
            list.Add("Mangoes");
            list.Add("Oranges");
            list.Add("Bananas");
            list.Remove("Bananas");
            list.Insert(2, "Kiwi Fruit");
            list.RemoveAt(1);
            Console.WriteLine("No of elements: " + list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
