using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Smith";
            //john.Introduce();

            //Calculator calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);

            int[] numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);    

            var names = new string[3] {"Jack", "John","Mary"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

        }
    }
}