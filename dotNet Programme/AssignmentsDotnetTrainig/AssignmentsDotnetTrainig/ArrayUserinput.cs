using System;

namespace ArraysInout
{
    class Assignment4
    {
        static void PrintValues(String[] myArr)
        {
            Console.WriteLine("String Array:");
            for (int i = 0; i < myArr.Length; i++)
            {
                //Console.WriteLine(myArr[i].GetType());
                Console.WriteLine("{0}", myArr[i]);
            }
            Console.WriteLine();
        }

        static void PrintValues(int[] myArr)
        {
            Console.WriteLine("Integer Array:");
            for (int i = 0; i < myArr.Length; i++)
            {
                //Console.WriteLine(myArr[i].GetType());
                Console.WriteLine("{0}", myArr[i]);
            }
            Console.WriteLine();
        }
        static String intToString(int s)
        {
            return s.ToString();
        }
        //static void takeInput(int len)
        //{
        //    Console.WriteLine("enter the  Array Elements");
        //    for (int i = 0; i <=len; i++)
        //    {
        //        arrayInt[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        public static void Main()
        {
            Console.WriteLine("enter the Size of Array");
            int sizeOfInput = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter the Type of Array INT for number or STR for String ");
            string tpofarray = Console.ReadLine();


            switch (tpofarray)
            {
                case "INT":
                    int[] arrayInt = new int[sizeOfInput];
                    Console.WriteLine("enter the  Array Elements");
                    for (int i = 0; i < sizeOfInput; i++)
                    {
                        arrayInt[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    PrintValues(arrayInt);
                    break;

                case "STR":
                    String[] conarr = new String[sizeOfInput];
                    Console.WriteLine("enter the  Array Elements");
                    for (int i = 0; i < sizeOfInput; i++)
                    {
                        conarr[i] = Console.ReadLine();
                    }
                    //String[] conarr = Array.ConvertAll(arrayInt, new Converter<int, String>(intToString));
                    PrintValues(conarr);
                    break;

            }

        }
    }
}
