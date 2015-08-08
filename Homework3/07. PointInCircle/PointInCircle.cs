using System;

namespace Problem7.PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            Console.Write("Enter value for x-coordinate: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Enter value for y-coordinate: ");
            double y = double.Parse(Console.ReadLine());

            bool isInside = (x * x) + (y * y) <= (2 * 2);

            if (isInside == true)
            {
                Console.WriteLine("The point you entered is within the circle");
            }
            else
                Console.WriteLine("The point you entered is not within the circle");
        }
    }
}
