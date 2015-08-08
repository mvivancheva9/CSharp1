using System;

namespace Problem10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            /*A beer time is after 1:00 PM and before 3:00 AM.
             * Write a program that enters a time in format “hh:mm tt” 
             * (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
             * and prints beer time or non-beer time according to the definition above or invalid 
             * time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
             */

            Console.Write("Enter time in 24 hour span in the format [0:00]:");
            DateTime time;
            string date = Console.ReadLine();

            if (DateTime.TryParse(date, out time))// check whether the entered value can be parsed to datetime
            {
                DateTime startTime = DateTime.Parse("1:00 PM");//set the start point for drinking beer
                DateTime endTime = DateTime.Parse("3:00 AM");//set the end point for drinking beer

                if (time > startTime || time < endTime)
                {
                    Console.WriteLine("Beer Time");
                }
                else
                {
                    Console.WriteLine("Non-beer Time");
                }
            }
            else
            {
                Console.WriteLine("Non-beer Time");
            }
            
        }
    }
}
