using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string output = "List";
            
            
            for (int n = 1 ; n <= 100; n++) 
            { 
             output = n.ToString();
                if (n % 3 == 0)

                {
                    output = "Fizz";
                   
                 
                };

                
                if (n % 5 == 0)

                {
                    output = "Buzz";

                };

                
                if (n % 3 == 0 && n % 5 == 0)


                {
                    output = "FizzBuzz";


                };


                Console.WriteLine(output);
            }
        
        }
    }


}