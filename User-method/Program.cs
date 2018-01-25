using System;

namespace AccountHolder
{
    class User
    {
        public static void Main()
        {
            string firstName;
            string lastName;
            bool isAnAccountOwner;
            int loginPin;

            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Thank you, {0} {1}.", firstName, lastName);
            Console.ReadLine();

            Console.Write("Are you an Account holder?");
            Console.ReadLine();
        }
    }

   
}
