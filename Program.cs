using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Activity11App
{
    public class DieTest
    {
        public static void Main(string[] args) 
        {
            Dice die1 = new Dice(6); // creates die1 object
            Dice die2 = new Dice(6); // creates die2 object

            int die1Roll, die2Roll; //variables to store dieRoll value
            int theNumberOfRolls = 0; //variable to count numberOfTimesDieRolled

            do
            {

                die1Roll = die1.rollDie(); // assigns the number to die1Roll
                die2Roll = die2.rollDie(); // assigns the number to die2Roll

                Console.WriteLine("Rolled [Dice 1: " + die1Roll + ", Dice 2: " + die2Roll + "]"); //prints to the console

                ++theNumberOfRolls; // increments each time

            } while (die1Roll != 1 || die2Roll != 1); //  while die1Roll is not equal to 1 or die2Roll is not equal to 1

            Console.WriteLine("\nIt took " + theNumberOfRolls + " rolls to get snake eyes!"); //prints to the console
        }
    }
}
