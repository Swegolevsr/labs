using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Venus : Planet, IHaveAngryResidents
    {
        public Venus () : base()
        {
            Name = "Венера";
        } 
        public override string Check(Student student)
        {
            return "";
        }
    }
}
