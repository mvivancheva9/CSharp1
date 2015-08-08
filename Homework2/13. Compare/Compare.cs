using System;

namespace Problem13. Compare
{
    class Compare
    {
        static void Main()
        {
            Console.Write("Enter the first floating-point number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Enter the second floating-point number: ");
            double secondNum = double.Parse(Console.ReadLine());

            double difference = firstNum - secondNum;
            bool isBigger = difference > 0.000001;
            bool equal = Math.Abs(difference) < 0.000001;  
            if(equal == true)
            {
                Console.WriteLine("The numbers you entered are equal!");
            }
            else 
            {
                if (isBigger == true)
                {
                    Console.WriteLine("The first number you entered is the bigger one");
                }
                else
                {
                    Console.WriteLine("The second number you entered is the bigger one");
                }
            }
                

            
        }
    }
}
