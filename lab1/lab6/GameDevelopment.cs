using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class GameDevelopment : Department
    {
        public GameDevelopment(string title) : base(title)
        {
        }

        public override void TraineeDistribution(List<Student> condidates)
        {
            List<Student> students = new List<Student>(condidates);
            foreach (Student student in students) {
                if (
                    (student.ProgrammingLanguage == ProgrammingLanguage.Cpp || student.ProgrammingLanguage == ProgrammingLanguage.CSharp)
                    && student.CourseNumber > 1
                    && student.Achievement >= 0.80)
                {
                    Trainees.Add(student);
                    condidates.Remove(student);
                }
            }
        }
    }
}
