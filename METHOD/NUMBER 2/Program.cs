using System;

namespace NUMBER_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string name = "Abdullah";
            Occurence(name);
        }
        public static void Occurence(string a)
        {
            int count = 0;
            foreach(var item in a)
            {
                if(item == 'a' ||item == 'e' ||item == 'i' ||item== 'o'||item == 'u')
                {
                    count ++;
                }
            }
            count += 0;
            Console.WriteLine("The vowel comes out "+ count + " times ");
        }

    }
}
