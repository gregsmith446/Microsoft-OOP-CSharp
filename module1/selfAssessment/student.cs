using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySelfTest
{
    public class Student
    {
        public string name { get; set; }
        public int Year { get; set; }
        public string dorm { get; set; }

        public Student(string name, int Year, string dorm)
        {
            this.name = name;
            this.Year = Year;
            this.dorm = dorm;

            // Every time the constructor runs, increment "instances"
            // This will keep track of the students enrolled
            instances++;
        }

        // Create integer variable called "instances"
        // Assigns instances an initial value of 0
        private static int instances = 0;

        public static int CountStudents()
        {
            return instances;
        }
    }
}
