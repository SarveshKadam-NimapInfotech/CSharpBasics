﻿namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var a = 10;
            //var b = 3;

            var a = 1;
            var b = 2;
            var c = 3;

            //Console.WriteLine(a+b);
            //Console.WriteLine((float)a/(float)b);
            Console.WriteLine(a+b*c);
            Console.WriteLine((a+b)*c);
            Console.WriteLine(a>b);
            Console.WriteLine(a==b);
            Console.WriteLine(a!=b);
            Console.WriteLine(!(a!=b));
            Console.WriteLine(c>b && c==a);
        }
    }
}