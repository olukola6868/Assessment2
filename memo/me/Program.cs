using System;

namespace me
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
        //     Console.WriteLine("enter the length of the array");
        //     int length = int.Parse(Console.ReadLine());
        //     int[]array = new int[length];
        //     for(int i = 0;i<array.Length;i++ )
        //     {
        //         Console.WriteLine("enter your numbers");
        //         array[i] = int.Parse(Console.ReadLine());
        //     }
        //     Console.Write("enter the number you want to check");
        //     int num = int.Parse(Console.ReadLine());
        //   Console.WriteLine(CountNumber( num , array));

        // }
        //  static int CountNumber(int number , int[]arr)
        // {
        //     int counter = 0;
        //     for(int i = 0;i< arr.Length;i++)
        //     {
        //         if(number == arr[i])
        //         {
        //             counter ++;
        //         }
        //     }
        //     return counter;

        int[]array = {-3,-2,5,4,9};
        Array.Sort(array);
       Console.WriteLine(array);




        }
    }
}
