using System;

namespace AccountHolder
{
    class User
    {
        public static void Main()
        {
            string firstName;
            string lastName;
            int loginPin = 0;
            string accountholder;

            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine($"Thank you, {firstName} {lastName}.");
            //            Console.ReadLine();
            
            do
            {
               Console.WriteLine("Are you account holder?");
                accountholder = Console.ReadLine();


            } while (accountholder.ToLower() != "yes");
            
            Console.WriteLine("Account holder " + accountholder);
            Console.ReadLine();
        }

    }
}
