using System;

namespace NUMBER_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("enter in pound to convert to kilogram");
            decimal input = Convert.ToDecimal(Console.ReadLine());
            decimal kilo = 0.454m;
            Console.WriteLine($"{input}pound is {kilo*input} kilogram");
          
        }
    }
}
