namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int hour = Convert.ToInt32(Console.ReadLine());

            //if(hour>0 &&  hour<12) 
            //{
            //    Console.WriteLine("It's Morning");
            //}
            //else if(hour>=12 && hour < 18)
            //{
            //    Console.WriteLine("It's Afternoon");
            //}
            //else
            //{
            //    Console.WriteLine("It's Evening");
            //}

            //bool isGoldCustomer = true;

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;

            //Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We 've got promotion");
                    break;

                default:
                    Console.WriteLine("I don't know the season!");
                    break;
            }

        }
    }
}