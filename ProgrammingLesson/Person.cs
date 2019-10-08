using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class Person  
    {
        public string firstName = "Alex";  //variable or data
        public string lastName = "Alufon";
        public int age = 32;
        public string address = "11 Redman lane, London";
        private double VAT = 20.0;  //this variable can only be used within this class because it is private
        
        public void PersonalDetails()  //this is a method or function
        {
            Console.WriteLine("His name is " + firstName + " " + lastName);
            Console.WriteLine("He's " + age + " years old");
            Console.WriteLine("He lives at " + address);
        }

        private void VatCalculation() //this method can only be used within this class because it is private
        {
            double finalValue = VAT * 1.2345;
            Console.WriteLine(finalValue);
        }

        public virtual void Bonus()
        {
            Console.WriteLine("His bonus is 20%");
            Console.WriteLine("This is from Superclass Person");
        }

    }
}
