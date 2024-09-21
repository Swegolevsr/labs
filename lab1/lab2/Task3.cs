using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace lab2
{
    internal class Task3
    {
        private int num, minutes;

        public void onStart()
        {
            Console.WriteLine("Write number: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                minutes = (num / 2) * 20 - 20;
            }
            else
            {
                minutes = (num / 2) * 20;
            }
            if (minutes < 480)
            {
                Console.WriteLine(minutes);
            } else
            {
                Console.WriteLine($"{minutes} dont wait");
            }
        }
    }
}
