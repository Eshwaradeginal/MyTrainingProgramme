using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    class DateTimeExmp
    {
        static void Main(string[] args)
        {

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.DayOfYear);
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToLongTimeString());
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine(dt.GetDateTimeFormats());
            Console.WriteLine(dt.GetType());
            Console.WriteLine(dt.ToString("dd/MM/yyyy"));
            Console.WriteLine($"{dt.Date}/{dt.Month}/{dt.Year}");
            Console.WriteLine("Enter a date");
            dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dt);

            Console.WriteLine( "enter date as dd/mm/yy");
           dt = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("Enter the Date of Birth");
            dt = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);
            var currDate = DateTime.Now;
            var span = DateTime.Now - dt;
            Console.WriteLine("The no of Days: " + span.TotalDays);
            Console.WriteLine("The no of years : "+(currDate.Year - dt.Year));
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int no = random.Next(10, 50);
                Console.WriteLine("The Date entered: " + currDate.AddDays(no).ToLongDateString());
                Thread.Sleep(2000);
            }


        }
    }
}
