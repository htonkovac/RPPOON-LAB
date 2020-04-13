using System;

namespace Dice {
    class RandomGenerator { 
        private static RandomGenerator instance; //unique instance
        private Random random;
        private RandomGenerator()
        {
            this.random = new Random();
        }
        //lazy instatation
        public static RandomGenerator GetInstance()
        {
            if (instance == null)
                instance = new RandomGenerator();
            return instance;
        }
        public int NextInt(int lowerBound, int upperBound)
        {
            return random.Next(lowerBound, upperBound);
        }
    }
}
