namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLength = 10;
            char[] buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = ((char)random.Next(97, 122));
                
            }

            string password = new string(buffer);
            Console.WriteLine(password);

        }
    }
}