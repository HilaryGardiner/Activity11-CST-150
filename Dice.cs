using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11App
{
    internal class Dice
    {
        private int numberOfSidesOfTheDie;

        // Generates random numbers
        private static Random randomNumber = new Random();

        public Dice(int numberOfSidesOfTheDie)
        {

            if (numberOfSidesOfTheDie < 4 || numberOfSidesOfTheDie > 20) // takes integer between 4 and 20
            {
                throw new ArgumentOutOfRangeException("Should be in range [4, 20] !");
            }

            this.numberOfSidesOfTheDie = numberOfSidesOfTheDie;
        }

        public int rollDie() // rollDie method
        {
            return randomNumber.Next(1, numberOfSidesOfTheDie + 1); //returns random number when the die is rolled
        }
    }
}
