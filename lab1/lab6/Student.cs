

namespace lab6
{
    internal class Student
    {
        public string Name { get; set; }
        public int CourseNumber { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }

        public double Achievement {  get; set; }

        public Student(){}

        public Student(string name, int coursenumber, ProgrammingLanguage pl, double achievement)
        {
            this.Name = name;
            this.CourseNumber = coursenumber;
            this.ProgrammingLanguage = pl;
            this.Achievement = achievement;
        }


    }
}

enum ProgrammingLanguage { 
    Cpp,
    CSharp,
    Python,
    Dart, Java,
    JavaScript
}