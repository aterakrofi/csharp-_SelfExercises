using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Teacher     // every teacher has a grade and a student as properties
    {

        public int Grade { get; set; }   // Grade is a property of teacher

        public string Student { get; set; }   // Student is a property of teacher


        public Teacher()     //We set this constructor and gave it values
        {

            Grade = 10;

            Student = "Ater";
        }

    }
}
