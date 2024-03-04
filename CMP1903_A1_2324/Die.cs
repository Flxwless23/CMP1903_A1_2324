using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private int currentValue;
        private Random random;

        public Die()  // This is the random number generator for multiple uses
        {
            random = new Random();
        }

        public int CurrentValue
        {
            get { return currentValue; }
        }


        public int Roll() //this will roll the dice between 1 and 6, then return the value to currentValue which will be displayed in result.
        {
            currentValue = random.Next(1, 7); // Rolls out a number between 1 and 6 (or whatever the lower / higher boundary is, then gets returned to currentValue)
            return currentValue;
        }

        }
  
    }