using System;

namespace Problem4.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter of the rectangle is: {0}", 2 * width + 2 * height );
            Console.WriteLine("The area of the rectangle is: {0}", width * height);
        }
    }
}
