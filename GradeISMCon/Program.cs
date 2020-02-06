using System;

namespace GradeISMCon
{
    class Program
    {
        static void Main(string[] args)
        {   //Init the variables
            int ISMGrade;
            string LetterGrade;
            //Asking user for input
            Console.WriteLine("Welcome to Grader!");
            Console.WriteLine("Please enter the grade percentage you think you will get in ISM 4300. No % sign");
            //Assigning the input to variables
            ISMGrade = int.Parse(Console.ReadLine());
            //Using conditional to assing letter grade to grade percentage. 
            if (ISMGrade >= 98)
            {
                LetterGrade = "A+";
            }
            else if (ISMGrade >= 92 && ISMGrade <= 97)
            {
                LetterGrade = "A";
            }
            else if (ISMGrade >= 90 && ISMGrade <= 91)
            {
                LetterGrade = "A-";
            }
            else if (ISMGrade >= 88 && ISMGrade <= 89)
            {
                LetterGrade = "B+";
            }
            else if (ISMGrade >= 82 && ISMGrade <= 87)
            {
                LetterGrade = "B";
            }
            else if (ISMGrade >= 80 && ISMGrade <= 81)
            {
                LetterGrade = "B-";
            }
            else if (ISMGrade >= 78 && ISMGrade <= 79)
            {
                LetterGrade = "C+";
            }
            else if (ISMGrade >= 72 && ISMGrade <= 77)
            {
                LetterGrade = "C";
            }
            else if (ISMGrade >= 70 && ISMGrade <= 71)
            {
                LetterGrade = "C-";
            }
            else if (ISMGrade >= 68 && ISMGrade <= 69)
            {
                LetterGrade = "D+";
            }
            else if (ISMGrade >= 62 && ISMGrade <= 67)
            {
                LetterGrade = "D";
            }
            else if (ISMGrade >= 60 && ISMGrade <= 61)
            {
                LetterGrade = "D-";
            }
            else
            {
                LetterGrade = "F";
            }
            //Finally writing the letter grade that they will get based on the percentage the user input
            Console.WriteLine("The letter grade of that is " + LetterGrade.ToString());
        }
    }
}
