using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class ThirdClass
    {
        public void ThirdMethod()
        {
            Console.WriteLine("7. Happy New Year. Hey I'm from the ThirdClass");
            Console.WriteLine("8. Happy New Year. Hey I'm from the ThirdClass");
            Console.WriteLine("9. Happy New Year. Hey I'm from the ThirdClass");
        }

        //Another name for a 'Method' is 'Function'
        //A'Method' with a 'void' cannot give back (return) anything to the caller
        //Once you are planning to return a value, you must change to return type from
        //'void' to a type that you would like to 'return' and include 'return' keyword
        public double Addition(double number1, double number2)  
        {
            double answer = number1 + number2;
            //Console.WriteLine("Addition of two numbers = " + answer);
            return answer;
        }
    }
}
