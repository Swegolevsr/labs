using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal abstract class Planet
    {
        public string Name { get; set; }
        public abstract string Check(Student student);

    }
}
