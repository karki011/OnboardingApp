using OnboardingApp;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace OnboardingApp
{
    class OnboardingApp
    {
        public static void Main()
        {
            string Accountholder;
            var user = new User();

            while (string.IsNullOrEmpty(user.FirstName))
            {
                user.FirstName = AskQuestion("Please enter your first name: ");
            }
            while (string.IsNullOrEmpty(user.LastName))
            {
                user.LastName = AskQuestion("Please enter your last name: ");
            }

            Console.WriteLine($"Thank you, {user.FullName}.");   
            do
            {
              Accountholder = AskQuestion("Are you account holder? | (Yes/No)");
            } while (Accountholder.ToLower() != "yes");
            Console.WriteLine($"Thank you {user.FullName}.");

            Console.WriteLine("What type of account do you have?");
            foreach (Accounts.AccountsType item in Enum.GetValues(typeof(Accounts.AccountsType)))
            {
                Console.WriteLine("{0}. {1}", (int)item, item);
            }

            Read:
            Console.WriteLine("Select your Account type: ");
            var select = Console.ReadLine();
            int option;
            if (!int.TryParse(select, out option))
            {
                goto Read;
            }
            option = Convert.ToInt32(select);
            Console.WriteLine("You have seleceted: {0}", Enum.ToObject(typeof(Accounts.AccountsType), option));

            user.PinNumber = AskIntQuestion("Please enter your account pin number.", 4);

            Console.WriteLine("Thank you for using our service.");
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        private static string AskQuestion(string question)
        {
            while (true)
            {
                Console.WriteLine(question);
                if (Console.ReadLine().Length != 0) return Console.ReadLine();
                Console.WriteLine("You didn't enter an answer");
            }
        }
        static int AskIntQuestion(string question, int length = 0)
        {
            var userInput = AskQuestion(question);
            if (length > 0 && length != userInput.Length)
            {
                Console.WriteLine("Invalid Entry!!");
                return AskIntQuestion(question, length);
            }
            if (int.TryParse(userInput, out var input)) return input;
            Console.WriteLine("Please try again!");
            return AskIntQuestion(question, length);
        }
    }
}
