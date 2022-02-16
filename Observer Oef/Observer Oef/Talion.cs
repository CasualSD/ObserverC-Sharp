using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Oef
{
    class Talion : ISubject
    {
        private int Talion_Health_;
        private bool Talion_Elven_Rage;
        private string Talion_Sword_Name;
        public int Talion_Health { get => Talion_Health_; }
        public bool Talion_ElvenRage { get => Talion_Elven_Rage; }
        public string Talion_SwordName { get => Talion_Sword_Name; }

        List<IObserver> observers = new List<IObserver>();

        public Talion(int Talion_Health, bool Talion_ElvenRage, string Talion_SwordName)
        {
            this.Talion_Health_ = Talion_Health;
            this.Talion_Elven_Rage = Talion_ElvenRage;
            this.Talion_Sword_Name = Talion_SwordName;
        }

        public void NotifiyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
        public void AddObservers(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObservers(IObserver observer)
        {
            observers.Remove(observer);
        }


    }

}
