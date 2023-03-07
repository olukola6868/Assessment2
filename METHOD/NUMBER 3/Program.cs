using System;

namespace NUMBER_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
              Console.WriteLine("Enter your number ");
            string number = Console.ReadLine();
            Console.WriteLine(Reverse(number));
        }
          public static string Reverse(string number)
        {
            char[]charArray =number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

      
