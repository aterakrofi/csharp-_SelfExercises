using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Teacher     // every teacher has a grade and a student as properties
    {

        public int grade { get; set; }

        public string student { get; set; }    

        public Teacher()
        {

            grade = 10;

            student = "Ater";
        }

    }
}
