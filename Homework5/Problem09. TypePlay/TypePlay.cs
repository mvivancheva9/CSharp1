using System;

namespace Problem09.TypePlay
{
    class TypePlay
    {
        static void Main()

            /*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
             * If the variable is int or double, the program increases it by one.
             * If the variable is a string, the program appends * at the end.
             * Print the result at the console. Use switch statement.*/
        {
            Console.WriteLine("Choose a type:\n1 ----> int\n2 ----> double\n3 ----> string");// prompt the use to enter a choice
            int choice = int.Parse(Console.ReadLine());

            switch (choice)// use switch to check the input and adequatly to react
            {
                case 1:
                    {
                        Console.Write("Please enter a integer: ");//the result when int is chosen
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine(a + 1);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Please enter a double: ");// the result when double is chosen
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine(b + 1.00);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Please enter a string: ");// the result when string is chosen
                        string c = Console.ReadLine();
                        Console.WriteLine(c + "*");
                        break;
                    }
                default: Console.WriteLine("Not correct choice!"); break;
            }
        }
    }
}
