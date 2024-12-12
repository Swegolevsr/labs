using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Student
    {
        public Student(string name, int samples, int surTest) {
            this.Name = name;
            this.samples = samples;
            this.surTest = surTest;
        }
        public string Name { get; set; }
        public int samples { get; set; }

        public int surTest { get; set; }
    }
}
