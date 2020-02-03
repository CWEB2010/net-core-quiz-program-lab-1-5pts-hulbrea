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
            string[] userChoices = { };
            string[] userSelection;
            string[] questions = { "What will be replacing .NET Core in 2020?", "What is the latest version of .NET Core?", "What platforms does .NET Core support?", "Who maintains .NET Core?"};
            
            
            // Two dimensional array with possible question answers
            string[,] optionChoices = {
                                        {"A. .NET Framework", "B. .NET 5", "C. .NET Applications", "D. There's nothing new coming"},
                                        
                                        {"A. 1.0", "B. 2.0", "C. 3.0", "D. 4.0"},
                                    
                                        { "A. Windows", "B. macOS", "C. Linux", "D. All of the above" },
                                        
                                        {"A. IBM", "B. Microsoft", "C. .NET community of GitHub", "D. B and C"},
                                      
            };

            int primingValue; 
            int EXIT = 2; //Sentenial Value


            Console.WriteLine("Welcome, this is a quiz on .NET Core. This quiz will consist of 3 questions. You must get 2 of the 3 correct to pass.");
            Console.WriteLine("To get started, enter the number '1'.");

            primingValue = Console.Read();

            while (primingValue != EXIT)
            {
                for (int x = 0; x < questions.Length; x++)
                {
                    Console.WriteLine(questions[x]);

                    for (int y = 0; y < optionChoices[x,y]; y++)
                    {
                        Console.WriteLine(optionChoices[x, y]);
                    }
                    Console.WriteLine("Please enter your selection");
                    userSelection = Console.ReadLine();

                    totalCorrect = 0;
                    totalIncorrect = 0;

                    if (userSelection = answerKey[x])
                    {
                        totalCorrect++;
                        Console.WriteLine("You got it right!");
                    }
                    else
                    {
                        totalIncorrect++;
                        Console.WriteLine("You got it wrong");
                    }
                    userChoices[x] = userSelection;
                }
                int totalCorrect;
                int totalIncorrect;
                Console.WriteLine("The quiz has been conclued, your results are listed below.");
                Console.WriteLine("Total Correct: " + totalCorrect);
                Console.WriteLine("Total Incorrect: " + totalIncorrect);

                if (totalCorrect >= 2)
                {
                    Console.WriteLine("You passed the quiz");
                }
                else
                {
                    Console.WriteLine("Sorry, you failed, please retake the quiz");

                }
                Console.WriteLine("To retake the quiz, please enter 1. Enter 2 to exit the quiz.");
                primingValue = Console.Read();
                }
                Console.WriteLine("Thank you for taking the .NET Core quiz");

        }
    }
}

