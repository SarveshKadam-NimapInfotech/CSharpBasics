namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mosh";
            var lastName = "Hamedani";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);

            Console.WriteLine(formattedNames);
            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);

            var text = @"Hi john\nLook into the ollowing paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);

        }

    }
}