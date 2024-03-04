using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Die part section
            Console.WriteLine("Die class Section");
            Die myDie = new Die();  // RNG under a new name
            int result = myDie.Roll(); // result is a new variable which will work with the Public Die from Die.cs and the public int Roll variable from Die.cs, Die.cs
            Console.WriteLine($"You rolled {result}"); // prints out the result
            // result will work with Die.cs to fetch the random number generator, and the .Roll part will ensure that number is between 1 and 6.
            
            
            Console.WriteLine("--------------------------------------------------------");

            // Game class section
            Console.WriteLine("Game class Section");

            Game DiceRoll = new Game();
            DiceRoll.DiceGame();
        }



            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
        }
    }