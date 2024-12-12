

namespace lab6
{
    internal class Department
    {
        public string Title { get; set; }
        public List<Student> Trainees { get; set; } = new List<Student>();
        public int NumberOfPositions { get; set; }

        public Department(string title) {
            this.Title = title;
        }

        public virtual void TraineeDistribution(List<Student> condidates)
        {
            foreach (Student student in condidates)
            {
                if (student.CourseNumber > 1)
                {
                    Trainees.Add(student);
                    condidates.Remove(student);
                }
            }
        }
    }
}
