using Baseline;
using System;
using System.ComponentModel.Design;

namespace Section5Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            SumOfAllEnteredNumbers();

        }

        /*
         *      1- Write a program and ask the user to enter a number. 
         *      The number should be between 1 to 10.
         *      If the user enters a valid number, 
         *      display "Valid" on the console. 
         *      Otherwise, display "Invalid".
         */
        static void ValidateNumber()
        {

            Console.WriteLine("Please, enter an integer number: ");
            var number = int.Parse(Console.ReadLine());

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

        static void IsHigher()
        {

            Console.WriteLine("Please, enter an integer number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter another integer number: ");
            var num2 = int.Parse(Console.ReadLine());

            int higher = num1 > num2 ? num1 : num2;
            Console.WriteLine($"{higher} is the higher number.");
        }


        /*
         * 3- Write a program and ask the user to enter the width and height of an image.
         *  Then tell if the image is landscape or portrait.
         */

        static void IsLandscapeOrPortrait()
        {
            Console.WriteLine("Enter the width and height of your image: ");
            double width = Double.Parse(Console.ReadLine());
            double heigth = Double.Parse(Console.ReadLine());

            String imageOrientation = heigth < width ? imageOrientation = "landscape" : imageOrientation = "portrait";
            Console.WriteLine($"Your image is {imageOrientation}.");
        }

        /*
         * 4- Your job is to write a program for a speed camera. For simplicity, 
         * ignore the details such as camera, sensors, etc and focus purely on the logic. 
         * 
         * 1- Write a program that asks the user to enter the speed limit. 
         * 2- Once set, the program asks for the speed of a car. 
         *  a. If the user enters a value less than the speed limit, program should display Ok on the console. 
         *  b. If the value is above the speed limit, the program should calculate the number of demerit points. 
         *      I. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
         *      II. If the number of demerit points is above 12, the program should display License Suspended.
         */

        static void SpeedCamera()
        {
            Console.WriteLine("Enter the Speed Limit: ");
            Double speedLimit = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car: ");
            Double carSpeed = Double.Parse(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if (carSpeed > speedLimit)
            {
                int demeritPoints = 0;
                for (demeritPoints = 0; carSpeed >= speedLimit + 5; demeritPoints++)
                {
                    carSpeed = carSpeed - 5;
                }

                if (demeritPoints <= 12) Console.WriteLine(demeritPoints); else Console.WriteLine("License Suspended");

            }
        }


        /*1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
         * Display the count on the console.
         */

        static void HowManyDivisibleByThree()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) count++;
            }

            Console.WriteLine(count);
        }

        /*
         * 2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
         * Calculate the sum of all the previously entered numbers and display it on the console.
         */

        static void SumOfAllEnteredNumbers()
        {
            var i = 0;
            var sum = 0;

            do
            {
                Console.WriteLine("Enter a number: ");
                i++;
                sum += Int32.Parse(Console.ReadLine());
                                                
            } while(Console.ReadLine().ToLower() != "ok");

            Console.WriteLine(sum);
        }

    }
}