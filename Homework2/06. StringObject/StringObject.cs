using System;

namespace Problem6.StringObject
{
    class StringObject
    {
        static void Main()
        {
            string firstGreeting = "Hello";
            string secondGreeting = "World";
            object together = firstGreeting + " " + secondGreeting;
            string final = (string)together;

            Console.WriteLine(final);
        }
    }
}
