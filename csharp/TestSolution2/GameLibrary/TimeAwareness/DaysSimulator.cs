using System.Threading;

namespace GameLibrary.TimeAwareness
{
    public abstract class DaysSimulator : Game
    {
        public int DayDuration { get; set; }

        public int DaysElapsed { get; private set; }

        public DaysSimulator()
        {
            DayDuration = 1000;
            //DaysElapsed = 0; // tego nie trzeba robić, ponieważ domyślą wartością dla pola typu int jest 0
        }

        protected override void Update()
        {
            /**
             * 
             * UWAGA
             * 
             * klasa Thread zawiera między innymi metodę Sleep(int milisecondsTimeout),
             * która wstyrzmuje "usypia" wykonywanie programu na podany czas w milisekundach
             * 
             */
            Thread.Sleep(DayDuration);

            //Console.WriteLine("Minął dzień {0}", ++DaysElapsed);
            UpdatePerDay(++DaysElapsed);
        }

        protected abstract void UpdatePerDay(int dayNum);
    }
}
