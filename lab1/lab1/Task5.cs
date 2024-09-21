using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Task5
    {
        private double a, b, c, d;

        public void Start() {
            Console.WriteLine("Write a, b, c, d in that order:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            Console.WriteLine((a/c)*(b/d) - ((a*b)-c)/(c*d) + Math.Sqrt(d));
        }
    }
}
