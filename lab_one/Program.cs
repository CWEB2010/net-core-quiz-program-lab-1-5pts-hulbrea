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
            string[] questions = { "Q1", "Q2", "What is the latest version of .NET Core?", "Q4", "What platforms does .NET Core support?", "Q6", "Q7", "Q8", "Who maintains .NET Core?", "Q10" };
            
            
            // Two dimensional array with possible question answers
            string[,] optionChoices = {
                                        {"A", "B", "C", "D"},
                                        {"A. IBM", "B. Microsoft", "C. Apple", "D. Nobody"},
                                        {"A. 1.0", "B. 2.0", "C. 3.0", "D. 4.0"},
                                        {"A. ", "B", "C.", "D"},
                                        { "A. Windows", "B. macOS", "C. Linux", "D. All of the above" },
                                        {"A", "B", "C", "D"},
                                        {"A", "B", "C", "D"},
                                        {"A. IBM", "B. Microsoft", "C. .NET community of GitHub", "D. B and C"},
                                        {"A", "B", "C", "D"},
            };

            int primingValue; 
            int EXIT = 2; //Sentenial Value
            int x, y;
            int totalCorrect, totalIncorrect;

            Console.WriteLine("Welcome, this is a quiz on .NET Core. This quiz will consist of 10 questions. You must get 7 of the 10 correct to pass.");
            Console.WriteLine("To get started, enter the number '1'.");

            //primingValue = Console.Read();

            /* while (primingValue != EXIT);
                for (x = 0; x < questions.Length; x++)
                Console.Read

    */



        


        }
    }
    }
}
