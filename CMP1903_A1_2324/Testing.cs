using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public void DieTesting (int value)
        {
            Debug.Assert(value <= 6, "Die generated above the value of 6 (Higher boundary)");
            Debug.Assert(value >= 1, "Die generated below the value of 1 (Low boundary)");
        }

        public void GameTesting(int value)
        {
            Debug.Assert(value <= 18, "Total number is above the value of 18 (Higher boundary)");
            Debug.Assert(value >= 3, "Total number is below the value of 3 (Lower boundary)");
        }
    }
}
