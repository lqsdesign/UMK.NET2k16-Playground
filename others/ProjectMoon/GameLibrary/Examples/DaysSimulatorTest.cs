using GameLibrary.TimeAwareness;
using System;

namespace GameLibrary.Examples
{
    public class DaysSimulatorTest : DaysSimulator
    {
        protected override void UpdatePerDay(int dayNum)
        {
            Console.WriteLine("Day {0}", dayNum);

            if (dayNum >= 5)
            {
                Console.WriteLine("This is last day.");
                Exit();
            }
        }

        protected override void OnExiting()
        {
            Console.WriteLine("Bye...");
            base.OnExiting();

            Console.WriteLine();
            Console.WriteLine("[Press enter to close]");
            Console.ReadLine();
        }
    }
}
