using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class Student : Person  //this is the concept of inheritance. 'Student' is a subclass while 'Person' is a superclass
    {
        public string position = "delegate";

        public void StudentPosition()
        {
            Console.WriteLine("He is a " + position);
        }

    }
}
