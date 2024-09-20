using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();
            Task4 task4 = new Task4();
            Task5 task5 = new Task5();
            Task6 task6 = new Task6();

            task1.Start();
            //task2.Start();
            //task3.Start();
            //task4.Start();
            //task5.Start();
            //task6.Start();

            Console.ReadKey();
        }
    }
}
