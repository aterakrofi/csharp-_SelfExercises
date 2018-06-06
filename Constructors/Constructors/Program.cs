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
            Teacher test = new Teacher();

            Console.WriteLine($"The grade that I teach is {test.grade}");
            Console.WriteLine($"My student's name is {test.student}");
        }
    }
}
