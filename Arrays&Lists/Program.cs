namespace Arrays_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------Arrays-------------------------
            //int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            ////Length
            //Console.WriteLine("length:" + numbers.Length);

            ////IndexOf()
            //var index = Array.IndexOf(numbers, 9);
            //Console.WriteLine("Index of 9:" + index);

            ////Clear()
            //Array.Clear(numbers, 0, 2);

            //Console.WriteLine("Effects of Clear()");
            //foreach (int i in numbers) Console.WriteLine(i);

            ////Copy()
            //int[] another = new int[3];
            //Array.Copy(numbers, another, 3);

            //Console.WriteLine("Effects of Copy()");
            //foreach (int i in another) Console.WriteLine(i);

            ////Reverse()
            //Array.Reverse(numbers);
            //Console.WriteLine("Effects of Reverse()");
            //foreach (int i in numbers) Console.WriteLine(i);

            //-------------------------------Lists-----------------------------------

            List<int> numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[] { 5, 6, 7 });

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Index os 1 :" + numbers.IndexOf(1));
            Console.WriteLine("Last Index os 1 : " + numbers.LastIndexOf(1));

            Console.WriteLine("Count :" + numbers.Count);

            for(int i = 0; i <numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
                
            }
             foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }

            numbers.Clear();
            Console.WriteLine("Count : " + numbers.Count);





        }
    }
}