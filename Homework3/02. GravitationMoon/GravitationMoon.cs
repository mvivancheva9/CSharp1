using System;

namespace Problem2.GravitationMoon
{
    class GravitationMoon
    {
        static void Main()
        {
            Console.Write("Enter your weight on the Earth: ");
            double weight = double.Parse(Console.ReadLine());

            double weightMoon = weight * 0.17;

            Console.WriteLine("Your weight on the Moon is: {0}", weightMoon);
        }
    }
}
