using System;

namespace Observer_Oef
{
    class Program
    {
        static void Main(string[] args)
        {
            Talion talion = new Talion(70, false, "Ragnorog");
            Observers spectator = new Observers(talion);

            talion.NotifiyObservers();
        }

    }
}
