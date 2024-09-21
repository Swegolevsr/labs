using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Task1
    {
        private int n;

        public void onStart() {
            Console.WriteLine("Write N:");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Second");
            }
            else
            {
                Console.WriteLine("First");
            }
        }

    }
}
