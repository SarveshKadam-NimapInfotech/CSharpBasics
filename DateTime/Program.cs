namespace DateTimeAndTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------DateTime----------------------
            //var dateTime = new DateTime(2015, 1, 1);
            //var now = DateTime.Now;
            //var today = DateTime.Today;

            //Console.WriteLine("Hours: " + now.Hour);
            //Console.WriteLine("Minute: " + now.Minute);

            //var tomorrow = now.AddDays(1);
            //var yesterday = today.AddDays(-1);
            //Console.WriteLine(tomorrow);
            //Console.WriteLine(yesterday);

            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.ToShortDateString());
            //Console.WriteLine(now.ToLongTimeString());
            //Console.WriteLine(now.ToShortTimeString());
            //Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //---------------------------TimeSpan-----------------------------
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration :" + duration);

            //Properties
            Console.WriteLine("Minutes: "+ timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add 
            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine(timeSpan.ToString());

            //Parse
            Console.WriteLine(TimeSpan.Parse("01:02:03"));








        }
    }
}