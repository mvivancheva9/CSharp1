using System;

namespace Problem9.Trapezoid
{
    class Trapezoid
    {
        static void Main()
        {
            Console.Write("Enter lenght for base a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter lenght for base b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("The are of the trapezoid is: {0}", ((a + b)/2) * h);

        }
    }
}
