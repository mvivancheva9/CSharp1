using System;

namespace Problem03.CirclePerimeterArea
{
    class CirclePerimeterArea
    {
        static void Main()
        {
            //Write a program that reads the radius r of a circle and prints its perimeter and area 
            //formatted with 2 digits after the decimal point.

            //Storing value for Pi
            double pi = 3.14159265359;
            //Prompting the user to enter value for the radius of the circle
            Console.Write("Enter raduis: ");
            double r;
            bool result = double.TryParse(Console.ReadLine(), out r);
            if (result == false)
            {
                Console.WriteLine("Enter a valid number");
            }

            Console.WriteLine("The area of the circle is: {0:F2} \nThe perimeter of the circle is: {1:F2}", pi * r * r, 2 * pi * r);
        }
    }
}
