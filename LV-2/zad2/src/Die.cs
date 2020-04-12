using System;

namespace Dice
{
    class Die
    {
        private int numberOfSides;
        private Random randomGenerator;
        public Die(int numberOfSides, Random randomGen)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomGen;
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}
