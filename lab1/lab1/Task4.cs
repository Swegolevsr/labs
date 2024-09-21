using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Task4
    {
        private int a;
        private int b;
        Random rnd = new Random();

        public void Start() {
            Console.WriteLine("First number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(rnd.Next(a, b));
        }

    }
}
