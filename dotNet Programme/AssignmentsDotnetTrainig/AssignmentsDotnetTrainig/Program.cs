using System;


namespace AssignmentsDotnetTrainig
{
    /*Write a function that takes an array of numbers and it should
        display the Odd and Even numbers*/
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr ={ 123, 564, 111, 25, 56 };
            Console.WriteLine(arr);
            int n = 0, m = 0;
            int[] odd =new int[5];
            int[] even=new int[5];
            for (int i= 0; i < 5;i++)
            {
                if(arr[i] %2 == 0)
                {
                    
                    odd[n++] = arr[i];
                    Console.WriteLine("number is odd : " + arr[i]);
                }
                else
                {
                    
                    even[n++] = arr[i];
                    Console.WriteLine("number is even : " + arr[i]);
                   
                }
                
            }
            

        }
    }
}
