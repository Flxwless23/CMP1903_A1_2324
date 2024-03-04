using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {

        public void DiceGame()
        {
            Die dieOne = new Die();
            dieOne.Roll();
            int dieOneValue = dieOne.CurrentValue;

            Die dieTwo = new Die();
            dieTwo.Roll();
            int dieTwoValue = dieTwo.CurrentValue;

            Die dieThree = new Die();
            dieThree.Roll();
            int dieThreeValue = dieThree.CurrentValue;

            //Console.WriteLine($"The roll of Die 1 is: {dieOneValue}");
            //Console.ReadLine();
            //Console.WriteLine($"The roll of Die 2 is: {dieTwoValue}");
            //Console.ReadLine();
            //Console.WriteLine($"The roll of Die 3 is: {dieThreeValue}");
            //Console.ReadLine();
            Console.WriteLine($"The total number of the three rolled dice is: {dieOneValue + dieTwoValue + dieThreeValue}");
            Console.ReadLine();
        }


        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods

    }
}