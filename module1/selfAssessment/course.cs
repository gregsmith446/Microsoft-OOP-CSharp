using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySelfTest
{
    public class Course
    {
        public string CourseName { get; set; }
        public Student[] students = new Student[3];
        public Teacher[] teachers = new Teacher[2];

        public Course(string _courseName)
        {
            this.CourseName = _courseName;
        }
    }
}
