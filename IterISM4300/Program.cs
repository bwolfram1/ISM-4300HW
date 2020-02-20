using System;

namespace IterISM4300
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInt;
            int iterInt;
            int numSys = 1;
            Console.WriteLine("Please enter a number between 2 and 10.");
            userInt = int.Parse(Console.ReadLine());

            if (userInt % 2 == 0)
            {
                iterInt = userInt + 1;
                
                for (int i = 0; i < iterInt; i++)
                {
                    
                    Console.WriteLine( numSys + ". You entered an Even number");
                    numSys++;
                }
            }
            else
            {
                iterInt = userInt - 1;
                for (int i = 0; i < iterInt; i++)
                {
                    
                    Console.WriteLine(numSys + ".You entered an Odd Number");
                    numSys++;
                }
                
                
            }
        }
    }
}
