using lab6;

internal class Program
{
    private static void Main(string[] args)
    {
        Student igor = new Student("Igor", 3, ProgrammingLanguage.CSharp, 0.90);
        Student oleg = new Student("Olega", 2, ProgrammingLanguage.Dart, 0.80);
        Student nikita = new Student("Nikita", 1, ProgrammingLanguage.Cpp, 0.6);
        Student jeka = new Student("Jendos", 4, ProgrammingLanguage.Java, 0.94);
        Student gnom = new Student("Gnom", 2, ProgrammingLanguage.Python, 0.87);
        Student anna = new Student("Anna", 3, ProgrammingLanguage.CSharp, 1);
        Student olga = new Student("Olga", 1, ProgrammingLanguage.JavaScript, 0.5);
        Student jack = new Student("Jack", 3, ProgrammingLanguage.Dart, 0.91);
        Student joker = new Student("Joker", 1, ProgrammingLanguage.JavaScript, 0.7);
        Student linus = new Student("Linus", 4, ProgrammingLanguage.Cpp, 1);
        
        List<Student> Candidates = new List<Student>() { igor, oleg, nikita, jack, jeka, gnom, anna, olga, joker, linus};
       
        Traineeship traineeship = new Traineeship();

        traineeship.Candidates = Candidates;

        GameDevelopment gameDevelopment = new GameDevelopment("Game development");
        DataScience dataScience = new DataScience("Data science");
        MobileApplicationDevelopment mobileApplicationDevelopment = new MobileApplicationDevelopment("Mobile development");

        traineeship.Departments = new List<Department>() { gameDevelopment, mobileApplicationDevelopment, dataScience };

        foreach (Department dp in traineeship.Departments)
        {
            dp.TraineeDistribution(traineeship.Candidates);
        }

        foreach (Department department in traineeship.Departments)
        {
            Console.WriteLine($"\nReady for {department.Title}:");
            foreach (Student student in department.Trainees)
            {
                Console.WriteLine(student.Name);
            }
            List<Student> noCandidate = Candidates.Except(department.Trainees).ToList();
            Console.WriteLine("\nNotReady:");
            foreach (Student student in noCandidate)
            {
                Console.WriteLine(student.Name);
            }

        }

    }
}