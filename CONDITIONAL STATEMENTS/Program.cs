using System;

namespace CONDITIONAL_STATEMENTS
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION 2
                // int choice,r,l,w,b,h;
                // double area = 0;
                // Console.WriteLine("Enter 1 for the area of a circle");
                // Console.WriteLine("Enter 2 for the area of a rectangle");
                // Console.WriteLine("Enter 3 for the area of a triangle");
                // choice = int.Parse(Console.ReadLine());
                // switch(choice)
                // {
                //     case 1:
                //         Console.Write("Input radius of the circle ");
                //         r = int.Parse(Console.ReadLine());
                //         area = 3.14 * r * r;
                //         break;
                //     case 2:
                //         Console.Write("Input length of the rectangle ");
                //         l = int.Parse(Console.ReadLine());
                //         Console.Write("Enter the height of the rectangle ");
                //         w = int.Parse(Console.ReadLine());
                //         area = l * w;
                //         break;
                //     case 3:
                //          Console.Write("Input base of the triangle ");
                //         b = int.Parse(Console.ReadLine());
                //         Console.Write("Enter the height of the triangle ");
                //         h = int.Parse(Console.ReadLine());
                //         area =(0.5 * (b * h));
                //         break;
                // }
                // Console.Write("The area is : {0} " , area);

                //NUMBER 3
                // string[]units = new string[]{"one","two","three","four","five","six","seven","eight","nine","ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","ninteen"};
                // string[]tens = new string[]{"Ten","twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninty"};
                // int i , num;
                // string result = " ";
                // Console.WriteLine("Enter number ");
                // num = int.Parse(Console.ReadLine());
                // if(num > 99 && num< 1000)
                // {
                //     i = num/100;
                //     result = units[i - 1] + "Hundred";
                //     num = num % 100;
                // }
                // if(num > 19 && num < 100)
                // {
                //     i = num / 10;
                //     result = result + tens[i - 1];
                //     num = num % 10;
                // }
                // if(num < 20 && num > 0)
                // {
                //     result = units[num - 1];
                // }
                // Console.WriteLine("The number you entered : " + result);

                //NUMBER 1
                // Console.WriteLine("guess what will occur when the two dice are rolled");
                // int input = int.Parse(Console.ReadLine());
                // Console.WriteLine("Enter the amount to bet from $ 1  - $ 1000");
                // int amount = int.Parse(Console.ReadLine());
                // Random number = new Random();
                // int random1 = number.Next(1 , 12);
                // if(input == random1)
                // {
                //     int get = amount * 8;
                //     Console.WriteLine($"your gift is {get/6}");
                // }
                // else
                // {
                //     Console.WriteLine("you loose");
                    
                // }


        }
    }
}
