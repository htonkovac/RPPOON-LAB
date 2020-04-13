using System.Collections.Generic;
using System;

namespace Dice
{
    class ClosedDiceRoller : IDiceRoller, ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public ClosedDiceRoller(int diceCount, int numberOfSides)
        {
            this.dice = new List<Die>();
            for (int i = 0; i < diceCount; i++)
            {
                this.dice.Add(new Die(numberOfSides));
            }
            this.resultForEachRoll = new List<int>();
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

    }
}
