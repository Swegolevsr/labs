using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Task2
    {
        private double a, b, c;

        public void onStart() {
            Console.WriteLine("Write 3 side of triangle: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            double[] sides = { a, b, c };
            Array.Sort(sides);

            if (sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2])
            {
                Console.WriteLine("rectangular");
            } else
            {
                double angleC = Math.Acos((sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) / (2 * sides[0] * sides[1])) / Math.PI * 180; ;
                Console.WriteLine($"not rectangular angle C = {angleC}");
            }
        
        }
    }
}
