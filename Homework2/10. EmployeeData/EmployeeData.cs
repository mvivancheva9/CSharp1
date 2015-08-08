using System;

namespace Problem10.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Margarita";
            string lastName = "Ivancheva";
            byte age = 25;
            char gender = 'f';
            long personalNumber = 8306112507;
            int empployeeNumber = 27560000;

            Console.WriteLine("The employee details with number: {0} are: \nname: {1} {2}, \nage: {3}, \ngender: {4}, \npersonal ID number: {5}",
                empployeeNumber, firstName, lastName, age, gender, personalNumber);
        }
    }
}
