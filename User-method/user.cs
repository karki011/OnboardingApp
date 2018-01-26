using System;
using System.Collections.Generic;
using System.Text;

namespace OnboardingApp
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => string.Join(" ",FirstName, LastName);

        public int PinNumber { get; set; }
    }
}
