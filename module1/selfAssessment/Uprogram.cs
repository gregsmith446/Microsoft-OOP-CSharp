using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySelfTest
{
    public class Uprogram
    {
        public string UProgramName { get; set; }
        public Degree[] degrees = new Degree[3];


        public UProgram(string _programName)
        {
            this.UProgramName = _programName;
        }

    }
}
