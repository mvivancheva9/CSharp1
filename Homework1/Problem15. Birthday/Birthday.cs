using System;

namespace Birthday
{
    class Birthday
    {
        static void Main()
        {
            DateTime now = DateTime.Now;

            Console.Write("Please enter the day of your birth: ");
            int birthDay = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter the month of your birth using numbers: ");
            int birthMonth = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter the year of your birth: ");
            int birthYear = int.Parse(Console.ReadLine());

            int ageNow = DateTime.Now.Year - birthYear;

            if (now.Month < birthMonth || (now.Month == birthMonth && now.Day < birthDay)) 
                
                ageNow--;


            Console.WriteLine("You are {0} years old now", ageNow);
            Console.WriteLine("After 10 years you will be {0} years old", ageNow+10);
        }
    }
}
