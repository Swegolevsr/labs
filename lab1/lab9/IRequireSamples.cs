using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal interface IRequireSamples
    {
        static bool Check(int samples)
        {
            if (samples > 20) return true;
            return false;
        }
    }
}
