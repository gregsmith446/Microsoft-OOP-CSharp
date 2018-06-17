using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySelfTest
{
    public class Teacher
    {
        // Define teacher class properties
        public string name { get; set; }
        public int age { get; set; }
        public string classTaught { get; set; }

        // Define an Constructor for the teacher class
        public Teacher(string name, int age, string classTaught)
        {
            this.name = name;
            this.age = age;
            this.classTaught = classTaught;

        }

    }
}
