using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV6
{
    class CareTaker
    {
        public List<Memento> PreviousStates { get; set; }
        public CareTaker() {
            PreviousStates = new List<Memento>();
        }

        public void AddState( Memento state) {
            this.PreviousStates.Add(state);
        }
        public Memento GetPreviousState() {
            return this.PreviousStates.Last();
        }

        public Memento GetInitialState() {
            return this.PreviousStates.First();
        }
    }
}
