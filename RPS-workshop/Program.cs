using System;
using System.Collections.Generic;

namespace RPS_workshop
{
    class Program
    {
         static void Main(string[] args)
        {
            char gameStart;
            bool loop;
            Console.WriteLine("Hello!");
            Console.WriteLine("Would you like to play Rock, Paper, Scissors: \n Y for yes  | N for no");
            gameStart = Console.ReadLine()[0];

            if (gameStart.Equals("Y") || gameStart.Equals("y"))
            {
                loop = true;
            }
            else if(gameStart.Equals("N") || gameStart.Equals("n")) 
            {
                loop = false;
                Environment.Exit(0);
            }
            else
            {
                loop = false;
            }

            //looping until false
            while (loop)
            {
                Console.WriteLine("Would you like to play Rock, Paper, Scissors: \n Y for yes  | N for no");
                gameStart = Console.ReadLine()[0];

                if (gameStart.Equals("Y") || gameStart.Equals("y"))
                {
                    loop = true;
                }
                else if (gameStart.Equals("N") || gameStart.Equals("n"))
                {
                    loop = false;
                    Environment.Exit(0);
                }
                else
                {
                    loop = true;
                }
            }
            List<String> options = new List<string>(3) { "Rock", "Paper", "Scissors" };
            Console.WriteLine("Enter your choice \n 1 for Rock \n 2 for paper \n 3 for scissors");
            string input;
            input = Console.ReadLine();
            int humChoice = Convert.ToInt32(input);
            humChoice -= 1;

            Random rand = new Random();

            int compChoice = rand.Next(0, 3);
            Console.WriteLine("The computer chose " + options[compChoice]);
            Console.WriteLine(compChoice);
            Console.WriteLine("You chose " + options[humChoice] +  "\n");
            Compare(compChoice, humChoice);

            static void Compare(int a, int b)
            {
                if(a == 0 && b == 2)
                {
                    Console.WriteLine("Computer Wins!");
                    Console.WriteLine("You lose");
                }
                else if (a == 1 && b == 0) 
                {
                    Console.WriteLine("Computer Wins!");
                    Console.WriteLine("You loses");
                }
                else if (a == 2 && b == 1)
                {
                    Console.WriteLine("Computer Wins!");
                    Console.WriteLine("You loses");
                }
                
                else if (a == b)
                {
                    Console.WriteLine("It was a draw");
                }
                else
                {
                    Console.WriteLine("You win!");
                    Console.WriteLine("Computer loses");
                }
            }
        }
    }
}
