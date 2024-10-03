using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Task2
    {
        private int N, sum, sumQ = 0;
      

        public void onStart() {
            Console.WriteLine("Write a number: ");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (sumQ + i * i < 500)
                {
                    sum += i;
                    sumQ += i * i;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Sum of elements: {sum}");
            Console.WriteLine($"Sum of square el: {sumQ}");
        
        }

    }
}
