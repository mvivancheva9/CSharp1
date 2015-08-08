using System;

namespace Problem06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            //Write a program that reads the coefficients a, b and c of a 
            //quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

            Console.Write("Enter coefficient a: "); 
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter coefficient b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter coefficient c: ");
            double c = double.Parse(Console.ReadLine());
            //creating a variable to store the determinant of the equation
            double determinant = (b * b) - 4 * a * c;
            //Checking the determinant for possible solutions of the equation
            if (determinant>0)
            {
                Console.WriteLine("The roots of the equation are: {0} and {1}", (-b - Math.Round(Math.Sqrt(determinant), 2)) / (2 * a), (-b + Math.Round(Math.Sqrt(determinant), 2)) / (2 * a));
            }
            else if (determinant == 0)
            {
                Console.WriteLine("The root of the equation is: {0}", -b/(2 * a));
            }
            else
                Console.WriteLine("The equation has no roots");
        }

    }
}
