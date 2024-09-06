using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Task1
    {
        private string name;
        private string language;
        public void Start()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What programming language have you learned before?");
            language = Console.ReadLine();
            Console.WriteLine($"I am {name}, I already know {language}");
        }
    }
}
