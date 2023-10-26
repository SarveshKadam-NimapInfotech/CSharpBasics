namespace ReferenceTypes_ValueTypes
{
    public class Person
    {
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var a = 10;
            //var b = a;
            //b++;
            //Console.WriteLine(string.Format("a:{0}, b:{1}", a, b));

            //var array1 = new int[3] {1,2,3};
            //var array2 = array1;
            //array2[0] = 0;
            //Console.WriteLine(string.Format("array1[0]:{0}, array2[0]:{1}", array1[0], array2[0]));

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person();
            var age = MakeOld(20);
            Console.WriteLine(age);


        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static int MakeOld(int  Age)
        {
           return Age += 10;
        }
    }
}