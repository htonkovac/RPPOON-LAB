namespace Dice
{
    class Die
    {
        public int numberOfSides { get; private set;}
        private RandomGenerator randomGenerator;
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}
