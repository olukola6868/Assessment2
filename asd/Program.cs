using System;

namespace asd
{        
     class Rectangle
    {
        public int length;
        public int breadth;

        public int Area()
        {
            // Console.WriteLine($"The area of the rectangle is: {length * breadth"});
            int area  = length * breadth;
            // Console.WriteLine(area); 
            return area;                                                                                   
        }
    }

    // class Person
    // {
    //     public string Name;
    //     public int Age;
    //     public string stateOfOrigin;

    //     public void Greeting()
    //     {
    //         Console.WriteLine("Hi! My name is "+ Name + " and i am " + Age + "years old and i am from "+ stateOfOrigin);
    //         // Console.WriteLine(Name);
    //     }
       
    // }


    class Program
    {
        static void Main(string[] args)
        { 
            Rectangle rectangle = new Rectangle();
            rectangle.length = 5;
            rectangle.breadth = 4;
            rectangle.Area();


            //  Person person1 = new Person();
            // person1.Name = "olukola Abdullahh";
            // person1.Age = 20;
            // person1.stateOfOrigin = "Oyo state";
            // person1.Greeting();
          

            // int[]array = {-3,-2,5,4,9};
            //  Array.Sort(array);
            // var b= array[array.Length-1] * array[array.Length-2];
            // Console.WriteLine(b);
           
            // for(int i = 0;i < array.Length;i++)
            // {
            //     count++;
            // }
            // Console.WriteLine(count);

            // Console.Write("n = ");
            // int n = int.Parse(Console.ReadLine());
            // Console.Write("m = ");
            // int m = int.Parse(Console.ReadLine());
            // int num = n;
            // long product = 1;
            // do
            // {
            //     product *= num;
            //     num++;
            // }while(num <= m);
            // Console.WriteLine(product);

            // Console.Write("n= ");
            // int n = int.Parse(Console.ReadLine());
            // double factorial = 1;
            // do{
            //     factorial *= n;
            //     n--;
            // }
            // while(n > 0);
            // Console.WriteLine(factorial);
            // Console.Write("n = ");
            // int n = int.Parse(Console.ReadLine());
            // decimal factorial = 1;
            // while(true);
            // {
            //     if(n <= 1)
            //     {
            //         Console.WriteLine(n);
            //         // break;
            //     }
            //     factorial*= n;
            //     n--;
            // Console.WriteLine(factorial);
            // }
            string word = "Abdullah ";
            Console.WriteLine(word.ToUpper());

        }
    }
}
