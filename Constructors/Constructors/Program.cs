using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher test = new Teacher();   // instantiate new teacher object

            //Teacher object has 2 properties grade and student
            Console.WriteLine($"The grade that I teach is {test.Grade}");
            Console.WriteLine($"My student's name is {test.Student}");
        }
    }
}
