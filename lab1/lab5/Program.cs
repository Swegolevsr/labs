using lab5;

internal class Program
{
    private static void Main(string[] args)
    {
        FitnessProgramm fitnessProgramm = new FitnessProgramm();

        int userAction = -1;
        while (userAction != 0)
        {

            Console.WriteLine("Добро пожаловать в программу для фитнеса\n\n");
            Console.WriteLine("1 - Задать имя и план тренировки");
            Console.WriteLine("2 - Установить целевую норму калорий");
            Console.WriteLine("3 - Задать новый план тренировок");
            Console.WriteLine("4 - Изменить план тренировок");
            Console.WriteLine("5 - Выполнить упражнение");
            Console.WriteLine("6 - Информация о вашей подготовке");
            Console.WriteLine("7 - Поднять мотивацию\n\n");
            Console.WriteLine("Для выхода введите 0");


            userAction = int.Parse(Console.ReadLine());
            switch (userAction)
            {
                case 0: return;
                case 1:
                    Console.WriteLine("Введите имя и после план тренировок:");
                    fitnessProgramm.Name = Console.ReadLine();
                    Console.WriteLine("Введите план тренировок:");
                    fitnessProgramm.ChangeExercisePlan(Console.ReadLine());
                    WaitUser();
                    break;

                case 2:
                    Console.WriteLine("\nВведите целевую норму калорий:");
                    fitnessProgramm.SetDailyTargetCalories(int.Parse(Console.ReadLine()));
                    Console.WriteLine("\nНовая цель поставлена");
                    WaitUser();
                    Console.Clear();
                    break;

                case 3:
                    Console.WriteLine("\nВведите новый план тренировок: ");
                    fitnessProgramm.ChangeExercisePlan(Console.ReadLine());
                    Console.WriteLine("\nПлан успешно изменен");
                    WaitUser();
                    break;

                case 4:
                    Console.WriteLine("Как вы хотите дополнить план:");
                    fitnessProgramm.UpdateExercisePlan(Console.ReadLine());
                    WaitUser();
                    break;

                case 5:
                    Console.WriteLine("Введите сколько калорий вы сожгли:");
                    fitnessProgramm.CompleteExercise(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Вы выполнили упражнение");
                    WaitUser();
                    break;

                case 6:
                    Console.WriteLine($"{fitnessProgramm.Name}, ты {fitnessProgramm.FitnessLevel}.");
                    if (fitnessProgramm.Warning)
                    {
                        Console.WriteLine("Нужно поработать еще");
                    } else
                    {
                        Console.WriteLine("Ты выполнил дневной план, можно и отдохнуть");
                    }
                    WaitUser();
                    break;

                case 7:
                    Console.WriteLine(fitnessProgramm.Motivate());
                    WaitUser();
                    break;

                default:
                    Console.WriteLine("Вы ввели неверное число.");
                    WaitUser();
                    break;
            }
        }
    }

    private static void WaitUser() {
        Console.WriteLine("\nНажмите enter для продолжения");
        Console.ReadLine();
        Console.Clear();
    }
}