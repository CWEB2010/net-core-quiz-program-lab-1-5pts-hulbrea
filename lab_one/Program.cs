//Brenna Hull
//CWEB2010 Advanced Programming
//Lab 1: Make a quiz over .NET

using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answerKey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string[] userchoices;
            string[] userSelection;
            string[] questions = { "Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "Q8", "Q9", "Q10" };
            
            
            // Two dimensional array with possible question answers
            string[,] optionChoices = {
                                        {"A", "B", "C", "D"},
                                        {"A", "B", "C", "D"},
                                        {"A", "B", "C", "D"},
                                        {"A", "B", "C", "D"},

            };

            int primingValue; 
            int EXIT = 2; //Sentenial Value
            int x, y;
            int totalCorrect, totalIncorrect;

            Console.WriteLine("Welcome, this is a quiz on .NET Core. This quiz will consist of 10 questions. You must get 7 of the 10 correct to pass.");
            Console.WriteLine("To get started, enter the number '1'.");

            primingValue = Console.Read();

        


        }
    }
    }
}
