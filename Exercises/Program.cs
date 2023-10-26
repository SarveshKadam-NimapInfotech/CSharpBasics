using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the speed limit (in km/hr): ");
            //int speedLimit = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the speed of the car (in km/hr): ");
            //int carSpeed = Convert.ToInt32(Console.ReadLine());

            //SpeedCamera sc = new SpeedCamera();
            //sc.speedCamera(speedLimit, carSpeed);

            //------------------------------------------------------------------------------------------------------------

            //int count = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine("The count of numbers between 1 and 100 divisible by 3 is: " + count);

            //------------------------------------------------------------------------------------------------------------

            //int sum = 0;

            //while (true)
            //{
            //    Console.Write("Enter a number or 'ok' to exit: ");
            //    string input = Console.ReadLine();

            //    if (input.ToLower() == "ok")
            //    {
            //        break; // Exit the loop if the user enters "ok"
            //    }

            //    if (int.TryParse(input, out int number))
            //    {
            //        sum += number;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a number or 'ok' to exit.");
            //    }
            //}

            //Console.WriteLine("The sum of all entered numbers is: " + sum);

            //------------------------------------------------------------------------------------------------------------

            //Console.WriteLine("Enter a number:");
            //int input = Convert.ToInt32(Console.ReadLine());

            //int result = factorial(input);
            //Console.WriteLine(result);

            //int factorial(int input)
            //{
            //    if(input <= 1)
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return input * factorial(input - 1);
            //    }
            //}

            //------------------------------------------------------------------------------------------------------------

            var random = new Random();
            int secretNumber = random.Next(1, 11);

            int attempts = 4;
            bool guessedCorrectly = false;

            for (int i = 0; i < attempts; i++)
            {
                Console.Write("Guess the number (between 1 and 10): ");
                if (int.TryParse(Console.ReadLine(), out int userGuess))
                {
                    if (userGuess == secretNumber)
                    {
                        guessedCorrectly = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again. You have " + (attempts - i - 1) + " more attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Display the result
            if (guessedCorrectly)
            {
                Console.WriteLine("You won! The secret number was " + secretNumber);
            }
            else
            {
                Console.WriteLine("You lost. The secret number was " + secretNumber);
            }

        }
    }
}