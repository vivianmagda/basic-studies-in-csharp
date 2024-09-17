using System;

namespace Section5Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter an integer number: ");
            var input = Console.ReadLine();
            var num1 = int.Parse(input);

            validateNumber(num1);

            Console.WriteLine("Please, enter another integer number: ");
            var input2 = Console.ReadLine();
            var num2 = int.Parse(input2);
                        
            higher(num1, num2);

        }

        /*
         *      1- Write a program and ask the user to enter a number. 
         *      The number should be between 1 to 10.
         *      If the user enters a valid number, 
         *      display "Valid" on the console. 
         *      Otherwise, display "Invalid".
         */
        static void validateNumber(int number)
        {
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine($"{number} is a valid number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a valid number.");
            }
        }

        /* 
         *      2- Write a program which takes two numbers 
         *      from the console and displays the maximum of the two.
         */

        static void higher(int num1, int num2)
        {
            int higher = num1 > num2 ? num1 : num2;
            Console.WriteLine($"{higher} is the higher number.");
        }


    }

    
}