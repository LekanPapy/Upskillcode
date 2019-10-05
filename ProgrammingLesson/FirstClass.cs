using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class FirstClass
    {
        //Constructor is a method with the same name as the class and no return keyword. 
        //It gets executed first when an instance of a class (an Object) is created.
        //It is mostly used to set default values

        public FirstClass()
        {
            Console.WriteLine("This is a constructor");
        }

        public FirstClass(int firstNumber, int secondNumber) //variables 'firstNumber' and 'secondNumber' are called Parameters
        {
            int sum = firstNumber + secondNumber;
            Console.WriteLine("Addition of two numbers = " + sum);  //concatenation concept
        }

        public void FirstMethod()   //default access modifier which is 'private' will be assigned to a method with no access modifier specified
        {
            Console.WriteLine("1. Happy New Year. Hey I'm from the FirstClass");
            Console.WriteLine("2. Happy New Year. Hey I'm from the FirstClass");
            Console.WriteLine("3. Happy New Year. Hey I'm from the FirstClass");
        }
    }
}
