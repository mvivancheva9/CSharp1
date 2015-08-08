using System;

namespace PrtFirstLastName
{
    class PrtFirstLastName
    {
        static void Main()
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your first name is: {0}", firstName);
            Console.WriteLine("Your last name is: {0}", lastName);
        }
    }
}
