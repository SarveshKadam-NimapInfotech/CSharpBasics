﻿namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for(int i = 10; i>=1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //var name = "john Smith";

            //foreach(var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //var numbers = new int[] {1, 2, 3, 4};

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
                
            }

        }
    }
}