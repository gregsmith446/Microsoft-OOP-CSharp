using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySelfTest
{
    public class Degree
    {
        public string DegreeName { get; set; }
        public Course[] courses = new Course[4];

        public Degree (string _degreeName)
        {
            this.DegreeName = _degreeName;
        }

    }
}
