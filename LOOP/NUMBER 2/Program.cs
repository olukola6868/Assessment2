using System;

namespace NUMBER_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the number yoou want to repeat");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1;i <= num;i++)
            {
                Console.WriteLine();
                for(int j = 1;j <= i;j++)
                {
                    Console.Write(i);
                }
            }
        }
    }
}
