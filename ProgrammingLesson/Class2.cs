using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class Class2
    {
        //There are 4 variables and 2 methods
        string firstName = "Wayne";  //Class level variable. It can be used by any methods
        string lastName = "Rooney";  //Class level variable. It can be used by any methods

        void Fullname()
        {
            Console.WriteLine("His fullname is " + firstName + " " + lastName);
            int age = 40; //A method level variable. It can only be used within this method
            Console.WriteLine("He's " + age + " years old");
            //Console.WriteLine("He's from " + city); 
        }

        void PersonalDetails()
        {
            Console.WriteLine("His fullname is " + firstName + " " + lastName);
            //Console.WriteLine("He's " + age + " years old");
            string city = "London"; //A method level variable. It can only be used within this method
            Console.WriteLine("He's from " + city);
        }
        
    }
}
