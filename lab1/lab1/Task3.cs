using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Task3
    {
        private int v;
        private int t;
        const int length = 163;
        private int score;
        private int fullCircles;

        public void Start() {
            Console.WriteLine("Write speed:");
            v = int.Parse(Console.ReadLine());
            Console.WriteLine("Write time:");
            t = int.Parse(Console.ReadLine());
            score = (v * t) % length;
            fullCircles = (v * t) / length;
            Console.WriteLine($"Score: {score}, full circles: {fullCircles}");
        }
    }
}
