using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Truck : Car
    {
        public int LoadCapacity;
        public override string FuelOfType()
        {
            return "Грузовик";
        }
    }
}
