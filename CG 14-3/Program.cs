using System;

namespace Timer14_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to my timer! Let me know how long to set the timer for. Enter time as, DD:HH:MM:SS");
                SetTimer timer = new SetTimer(Console.ReadLine());
                timer.TimerCount();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect format. Please use colon(:) between D:H:M:S");
            }

            Console.ReadLine();
        }
    }
}