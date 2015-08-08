using System;

namespace Problem02.CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            // A company has name, address, phone number, fax number, web site and manager. 
            //The manager has first name, last name, age and a phone number.
            //Write a program that reads the information about a company and its manager and prints it back on the console.

            Console.Write("Enter company name: ");//Prompting the user to enter desired information
            string companyName = Console.ReadLine();//Storing the information in newly created variable
            Console.Write("Enter company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            int companyPhone = int.Parse(Console.ReadLine());
            Console.Write("Enter company fax number: ");
            int companyFax = int.Parse(Console.ReadLine());
            Console.Write("Enter company website: ");
            string website = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string manFirstName = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string manLastName = Console.ReadLine();
            Console.Write("Enter manager age: ");
            int manAge = int.Parse(Console.ReadLine());
            Console.Write("Enter manager phone number: ");
            int manPhone = int.Parse(Console.ReadLine());

            Console.WriteLine(companyName);
            Console.WriteLine(" Address: {0} \n Tel. {1} \n Fax: {2} \n Web site: {3} \n Manager: {4} {5} (age: {6}, tel. {7})", companyAddress,companyPhone,companyFax, website, manFirstName, manLastName, manAge, manPhone);
        }
    }
}
