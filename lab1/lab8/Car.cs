using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal abstract class Car
    {
        public string Model;
        public string LicensePlate;
        public abstract string FuelOfType();
    }
}
