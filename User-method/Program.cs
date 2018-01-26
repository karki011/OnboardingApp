using OnboardingApp;
using System;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

namespace AccountHolder
{
    class OnboardingApp
    {
        public static void Main()
        {
            string accountholder;

            var user = new User
            {
                FirstName = AskQuestion("Please enter your first name: "),
                LastName = AskQuestion("Please enter your last name: ")
            };

            WriteLine($"Thank you, {user.FullName}.");
    
            do
            {
              accountholder = AskQuestion("Are you account holder? | (Yes/No)");
            } while (accountholder.ToLower() != "yes");

            WriteLine($"Thank you {user.FullName}.");

            user.PinNumber = AskIntQuestion("Please enter your account pin number.", 4);

            WriteLine($"Your login pin:  {user.PinNumber}");

            Console.ReadLine();
        }
        private static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }


        /// <summary>
        /// Ask a question user via console and get a numberic respose?
        /// </summary>
        /// <param name="question">Please enter your 4 digit pin?</param>
        /// <param name="length">number of int</param>
        /// <returns></returns>
        static int AskIntQuestion(string question, int length = 0)
        {
            var userInput = AskQuestion(question);

            if (length > 0 && length != userInput.Length)
            {
                WriteLine("Invalid Entry!!");
                return AskIntQuestion(question, length);
            }

            if (int.TryParse(userInput, out var input)) {return input;}

            WriteLine("Please try again!");
            return AskIntQuestion(question, length);
        }
    }
}
