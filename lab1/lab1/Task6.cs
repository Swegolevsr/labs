using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Task6
    {
        private double a, b, c;

        public void Start() { 
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            Console.WriteLine(Math.Sqrt(p*(p - a)*(p - b)*(p -c)));
        }    
    }
}
