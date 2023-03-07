using System;

namespace New_folder__2_
{
    class Program
    {
        //   static string ThePassword(string pass)
        //     {
        //         if(pass.Length >= 10)
        //         {
        //             return "Valid";
        //         }
        //         else
        //         {
        //             return "Invalid";
        //         }
                
        //     }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your word");
            string word = Console.ReadLine();
            int count = 0;
            foreach(var words in word)
            {
                if(word.Contains('a'))
                {
                    count+=1;
                    break;
                     Console.WriteLine($"a occured {count} times");.RNHTN 
                     
                     
                }
                else
                {
                    Console.WriteLine("is not available");
                }1
            }

            // Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            Console.WriteLine(ThePassword(password));

            if(password.Length >= 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

            Console.WriteLine("Please enter a Password: ");
            String password = Console.ReadLine();

            if (isValid(password))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        
             static bool isValid(String password)
            {
                if (password.Length < 8)
                {
                    return false;
                }
                else
                {
                    char c;
                    int count = 1;
                    for (int i = 0; i < password.Length - 1; i++)
                    {
                        c = password[i];
                        if (!Char.IsLetterOrDigit(c))
                        {
                            return false;
                        }
                        else if (Char.IsDigit(c))
                        {
                            count++;
                            if (count < 2)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
          


        }
       
    }
}
