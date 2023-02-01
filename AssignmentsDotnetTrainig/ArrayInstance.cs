using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsDotnetTrainig
{
    class ArrayInstance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of an array");
            int sizeofarray = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter thetype of an array to create");
            String typeofarray = Console.ReadLine();

            Type type = Type.GetType(typeofarray,true,true);
            Array myarr = Array.CreateInstance(type, sizeofarray);

            for(int i = 0; i < sizeofarray; i++)
            {
                Console.WriteLine($"enter the value of elements");
                string enteredvalue = Console.ReadLine();
                object convertedvalue = Convert.ChangeType(enteredvalue, type);
                myarr.SetValue(convertedvalue, i);
            }
            Console.WriteLine("All the values are set");
            foreach (object item in myarr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
