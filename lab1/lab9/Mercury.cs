using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Mercury : Planet, IRequireSurvivalTest
    {
        public Mercury() : base() {
            Name = "Меркурий";
        }

        public override string Check(Student student)
        {
            if (IRequireSurvivalTest.Check(student.surTest))
            {
                return "Готов к миссии!";
            }
            return "Не прошел тест на выживание.";
        }
    }
        
}
