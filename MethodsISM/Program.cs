using System;

namespace MethodsISM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brandon M. Wolfram");
            Console.WriteLine("Please enter the first number. (>0)");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number.(>0)");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the type.[1 to add, 2 to subtract, 3 to divide, and 4 to multipy]");
            int oper = int.Parse(Console.ReadLine());

            Console.WriteLine(Einstein(num1, num2, oper));
        }
        public static string Einstein(int x, int y,  int type)
        {
            try
            {
                if (type == 1)
                {
                    int result = x + y;
                    return ("The sum of " + x + " and " + y + " is " + result);
                }
                else if (type == 2)
                {
                    int result = x - y;
                    return ("The difference between " + x + " and " + y + " is " + result);
                }
                else if (type == 3)
                {
                    int result = x / y;
                    return ("When you divide " + x + " and " + y + " the result is " + result);
                }
                else if (type == 4)
                {
                    int result = x * y;
                    return ("When you multiply " + x + " and " + y + " the result is " + result);
                }
                else
                {
                    return ("You entered an unknown operation");
                }
            }
            catch
            {
                return ("You tried to divide by zero.");
            }

        }
        
    }
}
