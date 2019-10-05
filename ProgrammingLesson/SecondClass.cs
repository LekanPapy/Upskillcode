using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class SecondClass
    {    
        public void SecondMethod()
        {
            Console.WriteLine("4. Happy New Year. Hey I'm from the SecondClass");
            Console.WriteLine("5. Happy New Year. Hey I'm from the SecondClass");
            Console.WriteLine("6. Happy New Year. Hey I'm from the SecondClass");
        }    
        
        public void Multiplication(double number1, double number2, double number3)
        {
            double answer = number1 * number2 * number3;
            Console.WriteLine("Multiplication of three numbers = " + answer);
        }    
    }
}
