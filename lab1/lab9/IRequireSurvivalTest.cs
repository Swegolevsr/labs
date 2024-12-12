using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal interface IRequireSurvivalTest
    {
        static bool Check(int testRes) {
            if (testRes > 80) return true;
            return false;
        }
    }
}
