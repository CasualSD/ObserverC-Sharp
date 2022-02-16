using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Oef
{
    interface ISubject
    {
        public int Talion_Health { get; }
        public bool Talion_ElvenRage { get; }

        public string Talion_SwordName { get; }

        void NotifiyObservers();
        void AddObservers(IObserver observer);
        void RemoveObservers(IObserver observer);
    }
}
