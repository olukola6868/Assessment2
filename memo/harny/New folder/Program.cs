using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Enter your number to be checked");
            // int number = int.Parse(Console.ReadLine());
            // int divider =2;
            // int maxDiv = (int)Math.Sqrt(number);
            // bool prime = true;
            // while(prime && (divider <= maxDiv))
            // {
            //     if(number % divider == 0)
            //     {
            //         prime = false;
            //         Console.WriteLine(false);
            //     }
            //     else
            //     {
            //         divider ++;
            //     }
            // }
            //  Console.WriteLine(prime );
                
                // Console.WriteLine("Enter your number");
                // int number = int.Parse(Console.ReadLine());
                // bool IsCompletePrime = true;
                // while(number > 0 && IsCompletePrime)
                // {
                //     int LastNumber = number % 10;
                
                //     if(LastNumber < 2)
                //     {
                //         IsCompletePrime = false;
                //         break;
                //     }
                //     bool IsPrime = true;
                //     for(int i = 0;i < LastNumber;i++)
                //     {
                //         if(LastNumber % i == 0)
                //         {
                //             IsPrime = false;
                //             break;
                //         }
                //     }
                //      IsCompletePrime = IsPrime;
                //      number = number / 10;
                // }
               
                // if(IsCompletePrime = true)
                // {
                //     Console.WriteLine("The number is prime");
                // }
                // else
                // {
                //     Console.WriteLine("The number is not prime");
                // }

                // Console.WriteLine("Enter your word: ");
                // string word = Console.ReadLine();
                // bool isTrue = true;
                // for(int i = 0;i<word.Length/2;i++)
                // {
                //     if(word[i] == word[word.Length- i - 1])
                //     {
                //         isTrue = false;
                //         break;
                //     }
                // }
                // if(isTrue == true)
                // {
                //     Console.WriteLine("The word is palindrom");
                // }
                // else
                // {
                //     Console.WriteLine("The word is not palindrom");
                // }
                // int[]array = {1,2,3};
                // int sum = 0;
                // for(int i = 0;i < array.Length;i++)
                // {
                //     Console.WriteLine(sum += array[i]);
                // }

                Console.WriteLine("Enter the length of the array: ");
                int length = int.Parse(Console.ReadLine());
                int[]array = new int[length];
                for(int i = 0;i < array.Length;i++)
                {
                    Console.Write("Enter your numbers: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                int sum = 0;
                int result = 0;
                for(int i = 0;i <array.Length;i++)
                {
                    result = sum+= array[i];
                  //  Console.WriteLine($"the sum of the array is:  {sum += array[i]}");
                }

                Console.WriteLine($"the sum of the array is: {result}");


        }
    }
}
