
namespace lab5
{
    internal class FitnessProgramm
    {
        private string name;
        private bool isNameSet;
        public string Name
        {
            get => name;
            set
            {
                if (!isNameSet)
                {
                    name = value;
                    isNameSet = true;
                }
            }
        }
        public string ExercisePlan { get; private set; }

        public int CaloriesBurned { get; private set; }

        public int TotalExercises { get; private set; }

        public int DailyTargetCalories { get; private set; }

        public string FitnessLevel
        {
            get
            {
                if (CaloriesBurned > 2000)
                    return "Спортсмен";
                else if (CaloriesBurned > 1000)
                    return "Активный";
                else
                    return "Новичок";
            }
        }

        public bool Warning
        {
            get
            {
                return CaloriesBurned < DailyTargetCalories;
            }
        }


        public void CompleteExercise(int calories)
        {
            CaloriesBurned += calories;
            TotalExercises++;
        }

        public void ChangeExercisePlan(string NewPlan)
        {
            ExercisePlan = NewPlan;
        }

        public void UpdateExercisePlan(string updData)
        {
            ExercisePlan += " " + updData;
        }

        public void SetDailyTargetCalories(int target)
        {
            DailyTargetCalories = target;
        }

        public string Motivate() {
            string[] motiv = ["Ты справишься. То, что не убивает, делает нас сильнее", "Классно сегодня поработал", "Всегда можно лучше"];

            Random r = new();
            int index = r.Next(motiv.Length);
            return motiv[index];
        }
    }
}
