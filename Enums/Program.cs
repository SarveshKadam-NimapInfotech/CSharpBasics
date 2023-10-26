namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1 ,
        RegisterAirMail = 2,
        Express = 3
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            
            var methodId = 3; // In case you receive this number from database
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine(shippingMethod);

        }
    }
}