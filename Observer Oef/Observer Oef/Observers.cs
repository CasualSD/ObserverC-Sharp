using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Oef
{
    class Observers : IObserver
    {
        public ISubject PlayerStatistics;
        public void Update()
        {
            Console.WriteLine("Health is " + PlayerStatistics.Talion_Health + ".");
            Console.WriteLine("Elven Rage is " + PlayerStatistics.Talion_ElvenRage + ".");
            Console.WriteLine("Talion's equiped sword is " + PlayerStatistics.Talion_SwordName + ".");
        }

        public Observers(ISubject subject)
        {
            this.PlayerStatistics = subject;
            subject.AddObservers(this);
        }
    }
}
