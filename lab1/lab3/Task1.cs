using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Task1
    {
        private int num, numTry;
        private int countTry = 0;

        public void onStart()
        {
            Random random = new Random();
            num = random.Next(1,10);
            do
            {
                Console.WriteLine("Угодайте число");
                numTry = int.Parse(Console.ReadLine());
                if (numTry < num)
                {
                    Console.WriteLine("Попробуй больше");
                } else if (numTry > num)
                {
                    Console.WriteLine("Попробуй меньше");
                }
                countTry++;
            } while (num != numTry);
            Console.WriteLine($"Вы угадали с {countTry} попытки");
        }
    }
}
