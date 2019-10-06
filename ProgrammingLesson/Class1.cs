using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    static class Class1
    {
        //You can only have static members within a static class
        //By members I mean variables, functions/methods etc
        //But an instance class can implement static members (variables, functions/methods etc)

        public static string name = "Peter";
        public static int age = 40;

        public static void StudentDetails()
        {
            Console.WriteLine("My name is " + name + " and I'm " + age + " years old");
        }

    }
}
