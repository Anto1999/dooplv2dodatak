﻿using System;
using System.Collections.Generic;
using System.Text;

namespace labos2
{
    class Die
    {
        private int numberOfSides; private Random randomGenerator;

        public Die(Random randomGenerator, int numberOfSides)
        {
            this.randomGenerator = randomGenerator;
            this.numberOfSides = numberOfSides;
           
        }
        public Die(int numberOfSides) {
            this.numberOfSides = numberOfSides; this.randomGenerator = new Random();
        }

        public int Roll() {
            int rolledNumber = randomGenerator.Next(1, numberOfSides + 1); return rolledNumber;
        }
    }
}
