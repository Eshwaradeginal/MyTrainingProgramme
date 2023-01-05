using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    enum weekDays{mon,tues,wed,thur,fri};
    class EnumDatatype
    {
        static void Main(string[] args)
        {
            weekDays day = weekDays.mon;
            Console.WriteLine(day);
            Console.WriteLine("enter possibele values linke below :");
            Array possibleDays = Enum.GetValues(typeof(weekDays));
            for (int i = 0; i < possibleDays.Length; i++)
            {
                Console.WriteLine(possibleDays.GetValue(i));
            }
                object inpValue = Enum.Parse(typeof(weekDays), Console.ReadLine(), true);
                weekDays selectDay = (weekDays)inpValue;
                Console.WriteLine("selected day is :"+selectDay);
            }
        }
    }

