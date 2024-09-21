using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace lab2
{
    internal class Task4
    {
        private int type;
        private double sum;
        public void onStart() {
            Console.WriteLine("Write type of contribution:");
            type = int.Parse(Console.ReadLine());
            Console.WriteLine("Write sum of contribution:");
            sum = int.Parse(Console.ReadLine());

            switch (type) {
                case 1:
                    Console.WriteLine(sum*1.07 - sum);
                    break;
                case 2:
                    Console.WriteLine(sum*1.08*1.08*1.08 - sum);
                    break;
                case 3:
                    Console.WriteLine(sum * Math.Pow(1.1, 5) - sum);
                    break;
            }

           
        }
    }
}
