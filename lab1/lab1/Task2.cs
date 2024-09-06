using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Task2
    {
        private double x, y;
        private double angle;
        public void Start()
        {
            Console.WriteLine("Write X:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Write Y:");
            y = double.Parse(Console.ReadLine());
            angle = Math.Atan(y / x) * (180 / Math.PI);
            Console.WriteLine($"Angle is {angle}");
        }
    }
}
