using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class RandomGenerator
    {
        private static RandomGenerator instance;
        private Random generator;

        private RandomGenerator()
        {
            this.generator = new Random();
        }
        public static RandomGenerator GetInstance()
        {
            if(instance == null)
            {
                instance = new RandomGenerator();
            }
            return instance;
        }

        public int NextInt()
        {
            return this.generator.Next();
        }

        public int NextInt(int upperBound)
        {
            return this.generator.Next(upperBound);
        }

        public int NextInt(int lowerBound, int upperBound)
        {
            return this.generator.Next(lowerBound, upperBound);
        }

        public double NextDouble()
        {
            return this.generator.NextDouble();
        }
    }
}
