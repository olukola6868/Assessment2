using System;

namespace NUMBER_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int[,]arr = new int[8, 8];
            Console.WriteLine("Pascal triangle");
            for(int i = 0;i < 5;i++)
            {
                for(int k = 5;k > i;k--)
                {
                    Console.Write(" ");
                }
                for(int j = 0;j<i;j++)
                {
                    if(j == 0 || i == j)
                    {
                        arr[i , j] = 1;
                    }
                    else
                    {
                        arr[i,j] = arr[i - 1,j] + arr[i - 1, j - 1];
                    }
                    Console.Write(arr[i , j] + " ");
                }
                Console.ReadLine();
            }



        }
    }
}
