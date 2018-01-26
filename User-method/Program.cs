using System;
using static System.Console;

namespace AccountHolder
{
    class User
    {
        public static void Main()
        {
            string accountholder;

            Write("Please enter your first name: ");
            var firstName = ReadLine();

            Write("Please enter your last name: ");
            var lastName = ReadLine();

            WriteLine($"Thank you, {firstName} {lastName}.");
            do
            {
                WriteLine("Are you account holder?");
                accountholder = ReadLine();
            } while (accountholder.ToLower() != "yes");

            WriteLine($"Thank you {firstName} {lastName}.");

            WriteLine("Please enter your account pin number.");
            var userInput = ReadLine();
            var loginPin = Convert.ToInt32(userInput);
            WriteLine($"Your login pin:  {loginPin}");
            NewMethod();
        }

        private static void NewMethod()
        {
            var readLine = ReadLine();
        }
    }
}
