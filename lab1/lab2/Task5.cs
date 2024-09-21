using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Task5
    {
        private int v;
        public void onStart()
        {
            Console.WriteLine("Write speed:");
            v = int.Parse(Console.ReadLine());
            if (v <= 110) { 
                Console.WriteLine("Speed is normal for this road");
            }
            else if (v <= 130)
            {
                 Console.WriteLine("500");
            } else if (v <= 150)
            {
                Console.WriteLine("1500");
            } else if (v <= 170)
            {
                Console.WriteLine("2500 and disqualification for 4 months");
            } else
            {
                Console.WriteLine("5000 and disqualification for 6 months");
            }

        }
    }
}
