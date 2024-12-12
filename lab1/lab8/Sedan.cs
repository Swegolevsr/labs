using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Sedan : Car
    {
        public int TrunkCapacity;
        public override string FuelOfType() {

            return "sedan";

        }
    }
}
