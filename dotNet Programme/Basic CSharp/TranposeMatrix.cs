using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp.Programs
{
    class TranposeMatrix
    {
        private static void TransposeMatrx(int[,] arr)
        {
            try
            {

            for(int i = 0; i <= arr.GetLength(0); i++)
            {
                for(int j = 0; j <  arr.GetLength(1); j++)
                {

                    Console.Write(arr[j,i]+" ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            }catch (Exception ex)
            {

            }
        }

       
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 4, 2 }, { 3, 6, 8 }, { 1, 1, 1 } };
            ///TransposeMatrx(arr);
           sumofRows(arr);
            Console.WriteLine("================");
            int[,] arr1 = { { 1, 4}, { 3, 6} };
            sumofRows(arr1);

            Console.WriteLine("enter date");
            DateTime dt = DateTime.Now;
            getDates(dt);
            //Console.WriteLine("enter date as dd/mm/yy");
            //dt = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        }

        private static void getDates(DateTime dt)
        {
           
            for (int i = -1; i>= -15; i--)
            {
                Console.WriteLine("{0} yearsago: ",Math.Abs(i), dt.AddYears(i));
            Console.WriteLine();

            }

            
            for (int j = 1; j <= 15; j++)
            {

                Console.WriteLine("{} years from now:   {1:d}", j,dt.AddYears(j));
            }
        }










        public static void sumofRows(int[,] arr1)
        {
            try
            {
               
                for (int i = 0; i <= arr1.GetLength(0); i++)
                {
                    var sum = 0;
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {

                        sum += arr1[i,j];
                        Console.Write(arr1[i, j] + " ");
                    }
                    Console.Write(sum);
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
            }
            catch (Exception ex)
            {

            }
        }
    }
    


     
    }
