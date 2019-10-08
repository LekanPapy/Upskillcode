using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class Test
    {
        //within this class, we have managed to overload Addition methods
        double sum = 0;

        public void Addition(double one, double two)
        {
            sum = one + two;
            Console.WriteLine("Addition of two numbers = " + sum);
        }

        public void Addition(double one, double two, double three)
        {
            sum = one + two + three;
            Console.WriteLine("Addition of three numbers = " + sum);
        }

        public void Addition(double one, double two, double three, double four)
        {
            sum = one + two + three + four;
            Console.WriteLine("Addition of four numbers = " + sum);
        }
    }
}
