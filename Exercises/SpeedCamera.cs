namespace Exercises
{
    public class SpeedCamera
    {
        public void speedCamera(int speedLimit, int carSpeed)
        {

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit Points: " + demeritPoints);
                }
            }

        }
    }
}