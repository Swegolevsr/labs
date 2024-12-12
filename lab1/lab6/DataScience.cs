using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class DataScience : Department
    {
        public DataScience(string title) : base(title)
        {
        }

        public override void TraineeDistribution(List<Student> condidates)
        {
            List<Student> students = new List<Student>(condidates);
            foreach (Student student in students)
            {
                if (
                    student.ProgrammingLanguage == ProgrammingLanguage.Python
                    && student.Achievement >= 0.85)
                {
                    Trainees.Add(student);
                    condidates.Remove(student);
                }
            }
        }
    }
}
