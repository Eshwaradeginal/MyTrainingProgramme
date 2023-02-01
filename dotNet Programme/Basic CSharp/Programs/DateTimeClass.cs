using System;
using System.Threading;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class DateTimeClass
    {
        static void Main(string[] args)
        {
            DateTime dd = DateTime.Now;
            //1/6/2023 2:15:10 PM
            Console.WriteLine(dd);
            // Friday, January 6,2023
            Console.WriteLine(dd.ToLongDateString());
            //2:15:10 PM
            Console.WriteLine(dd.ToLongTimeString());
            //1/6/2023
            Console.WriteLine(dd.ToShortDateString());
            //2:15 PM
            Console.WriteLine(dd.ToShortTimeString());
            //1/6/2023 8:45:10 AM
            Console.WriteLine(dd.ToUniversalTime());
            //displayed in specified format
            Console.WriteLine(dd.ToString("dd/mm/yyyy"));
            Console.WriteLine($"{dd.Date}/{dd.Month}/{dd.Year}");

            //usre enter the date details
            Console.WriteLine("Enter the date");
            dd = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dd);
            //
            Console.WriteLine(" Enter the Date as dd/mm/yyy");
            dd = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);

            Console.WriteLine("Enter the Date of Birth");
            dd = DateTime.Parse(Console.ReadLine());

            var currDate = DateTime.Now;
            var span = DateTime.Now - dd;
            Console.WriteLine("The no of Days: " + span.TotalDays);
            Console.WriteLine("The no of Years: " + (currDate.Year - dd.Year));
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int no = random.Next(10, 50);
                Console.WriteLine("The Date entered: " + currDate.AddDays(no).ToLongDateString());
                Thread.Sleep(2000);
            }

        }

    }
}
