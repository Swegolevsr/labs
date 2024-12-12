using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Driver
    {
        public string Name;
        public int ExperienceYears;
        public MedicalCertificate MedicalCertificate;

        public Driver(string name, int experienceYears)
        {
            Name = name;
            ExperienceYears = experienceYears;
        }
    }
}
