using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class MobileApplicationDevelopment : Department
    {
        public MobileApplicationDevelopment(string title) : base(title)
        {
        }

        public override void TraineeDistribution(List<Student> condidates)
        {
            List<Student> students = new List<Student>(condidates);
            foreach (Student student in students)
            {
                if (
                    student.ProgrammingLanguage == ProgrammingLanguage.Dart
                    && student.CourseNumber == 3
                    && student.Achievement >= 0.90)
                {
                    Trainees.Add(student);
                    condidates.Remove(student);
                }
            }
        }
    }
}
