using System.Collections.Generic;
using System;

namespace Dice {
    class DiceRoller {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice() {
            //clear results of previous rolling
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

         //View of the results
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
                this.resultForEachRoll
            );
        }

        public int DiceCount
        {
            get { return dice.Count; }
        }
    }
}
