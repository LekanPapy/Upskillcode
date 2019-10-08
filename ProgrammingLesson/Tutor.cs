using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class Tutor : Person
    {
        public string role = "English language lecturer";

        public void Responsibility()
        {
            Console.WriteLine("He works as an " + role);
        }

        public override void Bonus()
        {
            Console.WriteLine("His bonus is 10%");
            Console.WriteLine("This is from Subclass Tutor");
        }
    }
}
