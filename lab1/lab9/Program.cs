
using lab9;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Planet> planets = new List<Planet>{new Mars(), new Venus(), new Mercury(), new Jupiter()};
        List<Student> students = new List<Student> {new Student("Иван Космонавтов", 25, 100), new Student("Анна Звездная", 23, 43), new Student("Кирилл Галактиков", 6, 100) };

        foreach (Planet planet in planets)
        {
            Console.WriteLine(planet.Name);
            Console.WriteLine("===============");
            if (planet is IHaveAngryResidents)
            {
                Console.WriteLine("На этой планете живут агрессивные жители, миссия невыполнима!");
            }
            else
            {
                foreach (Student student in students)
                {
                    Console.Write($"{student.Name}:");
                    Console.WriteLine(planet.Check(student));
                }
            }
            Console.WriteLine();
        }

    }
}