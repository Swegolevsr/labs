using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Mars : Planet, IRequireSamples, IRequireSurvivalTest
    {
        public Mars() : base() {
            Name = "Марс";
        }
        public override string Check(Student student)
        {
           if (IRequireSamples.Check(student.samples) && IRequireSurvivalTest.Check(student.surTest))
            {
                return "Готов к миссии!";
            } else if (IRequireSamples.Check(student.samples)) {
            
                return "Не собрал нужное кол-во образцов.";
            }
            return "Не прошел тест на выживание.";
        }
    }
}
