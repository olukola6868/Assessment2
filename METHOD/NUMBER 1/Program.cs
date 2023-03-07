using System;

namespace NUMBER_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            ThePassword(password);
        }
        static void ThePassword(string password)
        {
            string pass = "Babatunde8686";
            pass = pass.ToUpper;
            if(password == pass)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }


    }
}
