using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Jupiter : Planet, IRequireSamples
    {
        public Jupiter() : base() {
            Name = "Юпитер";
        }

        public override string Check(Student student)
        {
            if (IRequireSamples.Check(student.samples)) return "Готов к миссии!";
            return "Не собрал нужное кол-во образцов";
        }
    }
}
