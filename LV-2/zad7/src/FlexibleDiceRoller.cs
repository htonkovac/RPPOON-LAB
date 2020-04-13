using System.Collections.Generic;
using System;

namespace Dice
{
    class FlexibleDiceRoller : IDiceRoller, IFlexibleDiceRoller, ILogable
    {

        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

        public string GetStringRepresentation() {
            string representation = "";
            foreach (int rollResult in this.resultForEachRoll) {
                representation += rollResult + " ";
            }
            return representation;
        }

        public void RemoveDiceWithNSides(int numberOfSides) {
            dice.RemoveAll(die => die.numberOfSides == numberOfSides);
        }
    }
}
