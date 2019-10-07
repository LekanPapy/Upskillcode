using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class Program
    {
        static void Main(string[] args) //an entry point
        {
            //Must learn C-sharp keywords / syntax are
            //Class (instance (covered), static)
            //Class (covered), Constructor (covered), Object (covered)
            //Method / Function (void (covered), datatype (return) (covered), argument (covered)/parameter (covered))
            //Datatypes (string (covered), integer (covered), boolean (covered) , var (covered), double (covered) etc)
            //Access modifier (private (covered), public (covered), sealed, protected etc)
            //String manipulation (covered), String concatenation (covered)
            //Operators (+ (covered), - (covered), * (covered), / (covered), % (covered))
            //Comparison operators (== (covered), <= (covered), >= (covered), != (covered), && (covered), || (covered) etc)
            //Control statements (Selection and Iteration (covered))
            //Selection statements (if (covered), switch-case (covered))
            //Iteration statements (for (covered), while (covered), foreach (covered))
            //Collections (List (covered), Dictionary (covered), Array (covered), ArrayList (covered))
            //Object Oriented Programming Concepts <OOP> 
            //OOP (Encapsulation, Polymorphism, Inheritance, Abstraction)
            //Read and write of data to a file (Notepad) (covered) and SQL Server Database (covered)
            //Debugging (covered)
            //Try-catch (error or exception handling) (covered)
            //Code refactoring (covered)

            ////Explanation 
            //int age = 55;  //int = datatype, age = variable, 55 = value or data
            //string firstName = "Becky"; //string = datatype, firstName = variable, Becky = value or data
            //int firstName2 = Convert.ToInt16("Ola");


            ////Task 1
            ////Write a computer program to add two numbers. Display the result 
            ////to the console
            ////Hint: you will need the followings
            ////(1) 3 variables which can be 'firstNumber', 'secondNumber', 'answer'
            ////(2) Datatype(s) for each variable. An integer type for all variables
            ////(3) Operator addition '+' and an assignment symbol which is '='

            //Console.WriteLine("Computer program to add two numbers");
            //Console.WriteLine("What is the first integer number to add");
            //int firstNumber = Convert.ToInt16(Console.ReadLine());  //Console.ReadLine() means get an input from a user at runtime
            //Console.WriteLine("What is the second integer number to add");
            //int secondNumber = Convert.ToInt16(Console.ReadLine());
            //int answer = firstNumber + secondNumber;
            //Console.WriteLine("Addition of two numbers = " + answer);              //Console.WriteLine(answer) means display an answer to the console //Concatenation


            ////Task 2
            ////Write a computer program to add two numbers of any type (decimal or integer). 
            //// Display the result to the console
            ////Hint: you will need the followings
            ////(1) 3 variables which can be 'firstNumber', 'secondNumber', 'answer'
            ////(2) Datatype(s) for each variable. A double type for all variables
            ////(3) Operator addition '+' and an assignment symbol which is '='
            ////
            //Console.WriteLine("Computer program to add two numbers");
            //Console.WriteLine("What is the first number to add");
            //double firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("What is the second number to add");
            //double secondNumber = Convert.ToDouble(Console.ReadLine());
            //double answer = firstNumber + secondNumber;
            //Console.WriteLine($"Addition of {firstNumber} and {secondNumber} = {answer}");

            ////Task 3
            ////Write a computer program to multiply three numbers of any type (decimal or integer). 
            //// Display the result to the console
            ////Hint: you will need the followings
            ////(1) 4 variables which can be 'firstNumber', 'secondNumber', 'thirdNumber', 'answer'
            ////(2) Datatype(s) for each variable. A double type for all variables
            ////(3) Operator multiplication '*' and an assignment symbol which is '='
            ////
            //Console.WriteLine("Computer program to multiply three numbers");
            //Console.WriteLine("Input the first number to multiply and press enter");
            //double firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Input the second number to multiply and press enter");
            //double secondNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Input the third number to multiply and press enter");
            //double thirdNumber = Convert.ToDouble(Console.ReadLine());
            //double answer = firstNumber * secondNumber * thirdNumber;
            //Console.WriteLine($"Multiplication of {firstNumber} , {secondNumber} and the {thirdNumber} = {answer}");

            ////Task 4
            ////Write a computer program to divide two numbers of any type (decimal or integer). 
            //// Display the result to the console
            ////Hint: you will need the followings
            ////(1) 3 variables which can be 'firstNumber', 'secondNumber', 'answer'
            ////(2) Datatype(s) for each variable. A double type for all variables
            ////(3) Operator division '/' and an assignment symbol which is '='
            ////
            //Console.WriteLine("Computer program to divide two numbers");
            //Console.WriteLine("Input the first number to divide and press enter");
            //double firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Input the secondNumber number to divide and press enter");
            //double secondNumber = Convert.ToDouble(Console.ReadLine());
            //double answer = firstNumber / secondNumber;
            //Console.WriteLine($"Division of {firstNumber} and {secondNumber} = {answer}");

            ////Task 5
            ////Write a computer program to find a remainder of division of two numbers 
            //// Display the result to the console
            ////Hint: you will need the followings
            ////(1) 3 variables which can be 'firstNumber', 'secondNumber', 'answer'
            ////(2) Datatype(s) for each variable. A double type for all variables
            ////(3) Operator modulo '%' and an assignment symbol which is '='
            //// 
            //Console.WriteLine("Computer program to find a remainder of division of two numbers");
            //Console.WriteLine("Input the first number to find a remainder for and press enter");
            //double firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Input the secondNumber number to find a remainder for and press enter");
            //double secondNumber = Convert.ToDouble(Console.ReadLine());
            //double answer = firstNumber % secondNumber;
            //Console.WriteLine($"Remainder of {firstNumber} and {secondNumber} = {answer}");

            ////Task 6
            ////If-statement              
            ////To get a code snippet, type the first keyword and press 'Tab' key twice
            ////Write a computer program to ask a user to input a whole number. Then tell a 
            ////user if the inputted number is an 'even' or 'odd' number by displaying it to console
            ////An even number is a number that is divisible by 2 with remainder 0
            ////An odd number is a number that is divisible by 2 with remainder 1
            //Console.WriteLine("Input an integer number and press enter");
            //int number = Convert.ToInt16(Console.ReadLine());
            //if (number % 2 == 0)  //this is to test for an even number
            //{
            //    Console.WriteLine($"{number} is an even number");
            //}
            //else if (number % 2 == 1)  //this is to test for an odd number
            //{
            //    Console.WriteLine($"{number} is an odd number");
            //}


            ////Task 7
            ////Write a computer program to display "Happy New Year" 9 times            
            ////Use the Main method within the Program Class to solve the problem
            //Console.WriteLine("1. Happy New Year");
            //Console.WriteLine("2. Happy New Year");
            //Console.WriteLine("3. Happy New Year");
            //Console.WriteLine("4. Happy New Year");
            //Console.WriteLine("5. Happy New Year");
            //Console.WriteLine("6. Happy New Year");
            //Console.WriteLine("7. Happy New Year");
            //Console.WriteLine("8. Happy New Year");
            //Console.WriteLine("9. Happy New Year");

            //// Task 8
            ////Write a computer program to display "Happy New Year" 9 times
            ////Use 3 new methods within the Program Class to solve the problem
            //FirstMethod();
            //SecondMethod();
            //ThirdMethod();

            //// Task 9
            ////Write a computer program to display "Happy New Year" 9 times
            ////Use 3 new methods that belong to 3 different classes apart from Program Class
            //FirstClass firstClassObj = new FirstClass();   //new keyword means create an instance of a class i.e. Object
            //SecondClass secondClassObj = new SecondClass();
            //ThirdClass thirdClassObj = new ThirdClass();
            //firstClassObj.FirstMethod();
            //secondClassObj.SecondMethod();
            //thirdClassObj.ThirdMethod();

            //// Task 10
            ////Constructor is a method with the same name as the class and no return keyword. 
            ////It gets executed first when an instance of a class (an Object) is created
            ////Write a computer program to create a class with atleast two constructors
            ////where two of them are doing different things. Use the existing 'FirstClass'
            ////to demonstrate it
            //FirstClass firstClassObj = new FirstClass();
            //FirstClass firstClassObj2 = new FirstClass(2, 2); //values 2,2 are called 'Arguments'

            ////Task 11
            ////Concept behind Arguments and Parameters
            ////Write a computer program to allow a method to take three parameters that 
            ////that can be used for multiplication within that method. Use 'SecondClass' to 
            ////implement the method
            //SecondClass secondClassObj = new SecondClass();
            //secondClassObj.Multiplication(2, 3, 2); //values 2,3,4.5 are called 'Arguments'
            //Alternatively, you can have three variables declared with values and use 
            //those variables when 'Multiplication' method is called or referenced
            //double num1 = 4.2;
            //double num2 = 3;
            //double num3 = 4.5;
            //secondClassObj.Multiplication(num1, num2, num3);
            //// You can aswell get the values from users at run time by using Console.ReadLine();
            //Console.WriteLine("Input the first number and press enter");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Input the second number and press enter");
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Input the third number and press enter");
            //double number3 = Convert.ToDouble(Console.ReadLine());
            //secondClassObj.Multiplication(number1, number2, number3);

            ////Task 12            
            ////Concept behind a non-void method i.e. a method that return a value
            ////Write a computer program to allow a method to take two parameters that 
            ////that can be used for addition within that method. 
            ////Return the answer to a variable that will call it and multiply the answer
            ////by 3 to get a new value to be written to the console. 
            ////Use 'ThirdClass' to implement the method
            //ThirdClass thirdClassObj = new ThirdClass();
            //double answer = thirdClassObj.Addition(4,5);
            //var newAnswer = answer * 3;  //var can be used to implicitly old a variable datatype i.e. use 'var' instead of 'double'
            //Console.WriteLine("New answer is = " + newAnswer);

            //var name = "Joy";
            //var age = 30;


            ////Task 13
            ////Concept behind de-bugging i.e. step into the written code one after the other 
            ////at run time. Use both 'F10' => step over and 'F11' => step into keys to 
            ////handle this concept. Make sure you have in place a breakpoint (the first thing)
            ////Write a computer program to allow a method to take two parameters that 
            ////that can be used for addition within that method. 
            ////Return the answer to a variable that will call it and multiply the answer
            ////by 3 to get a new value to be written to the console. 
            ////Use 'ThirdClass' to implement the method
            //ThirdClass thirdClassObj = new ThirdClass();
            //double answer = thirdClassObj.Addition(4, 5);
            //var newAnswer = answer * 3;  //var can be used to implicitly old a variable datatype i.e. use 'var' instead of 'double'
            //Console.WriteLine("New answer is = " + newAnswer);

            ////Task 14
            ////Write a computer program to add two numbers. Cater for error or exception 
            ////handling by implementing try-catch
            //try
            //{
            //    Console.WriteLine("Computer program to add two numbers");
            //    Console.WriteLine("What is the first number to add");
            //    double firstNumber = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("What is the second number to add");
            //    double secondNumber = Convert.ToDouble(Console.ReadLine());
            //    double answer = firstNumber + secondNumber;
            //    Console.WriteLine($"Addition of {firstNumber} and {secondNumber} = {answer}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("Please input an integer or decimal number");
            //}

            //string name1 = "Dayo";
            //string name2 = "Sandra";
            //string name3 = "Ranti";
            //string name4 = "Becky";
            ////Console.WriteLine("Names are " + name1 +", "+ name2 + ", "+ name3 + ", " + name4);
            //Console.WriteLine(name1);

            ////Task 15
            ////Concept of collections with an Array. You can have an array of different datatypes i.e. string, int etc.
            ////Implement an Array of string to hold 4 students. Give the student names
            ////at the point of declaration and  print to the console those names
            //string[] names = new string[] { "Dayo", "Sandra", "Ranti", "Becky" };
            ////Console.WriteLine(names);  //You can't see the data in a collection with this option
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            ////Task 16            
            ////Implement an Array of string to hold 4 students. Do not give the student names
            ////at the point of declaration. Assign names to the array before printing
            ////those names to the console
            //string[] names = new string[4];
            //names[0] = "Dayo";
            //names[1] = "Sandra";
            //names[2] = "Ranti";
            //names[3] = "Becky";            
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //////Task 17            
            ////Implement an Array of integers to hold 4 students age. Give their age
            ////at the point of declaration and  print to the console those values
            //int[] ages = new int[] { 30,40,45,55 };
            ////Console.WriteLine(names);  //You can't see the data in a collection with this option
            //foreach (var age in ages)
            //{
            //    Console.WriteLine(age);
            //}

            ////Task 18
            ////Implement an Array of integers to hold 4 students age. Give their age
            ////at the point of declaration and print to the console those values with more than or equal to 40
            //int[] ages = new int[] { 40, 38, 45, 32 };            
            //foreach (var age in ages)
            //{
            //    if (age >= 40)
            //    {
            //        Console.WriteLine(age);
            //    }
            //}

            ////Task 19
            ////Implement a List of string to hold students names. List can evolve
            ////Firstly, print an empty list to the console
            ////Secondly, provide few student names and print them to the console
            ////Thirdly,  create a sub-list and add it to the main list and everything to the console
            ////Lastly, remove a few names from the list and print the rest to the console
            //List<string> names = new List<string>();
            ////result with no values
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine();
            ////provide few student names to the list            
            //names.Add("Becky");
            //names.Add("Ranti");
            //names.Add("Sandra");
            //names.Add("Enitan");
            //names.Add("Theresa");
            //names.Add("Insider");
            //names.Add("Outsider");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine();
            ////Third requirement
            //List<string> subList = new List<string>() { "Yinka", "Lekan" };
            //names.AddRange(subList);
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine();
            ////Last requirement
            //names.Remove("Insider");
            //names.Remove("Outsider");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine();

            ////Task 20
            ////ArrayList, as a collection, can be used to manage a group of data with 
            ////different datatypes. For example, Arraylist allows int, string, boolean,
            ////doulbe etc on the list. This is not possible with a List.
            //ArrayList dataCollection = new ArrayList() { "Becky", 56, false, 34.23 };
            //foreach (var data in dataCollection)
            //{
            //    Console.WriteLine(data);
            //}

            ////How to get datatype out of a variable
            //string name = "Joy";
            //int age = 30;
            //double value = 34.23;
            //bool maleGender = true;

            //Console.WriteLine(name.GetType().ToString());
            //Console.WriteLine(age.GetType().ToString());
            //Console.WriteLine(value.GetType().ToString());
            //Console.WriteLine(maleGender.GetType().ToString());

            ////Task 21
            ////ArrayList task to do. Print to the console only boolean in the collection
            //ArrayList dataCollection = new ArrayList() { "Becky", 56, false, 34.23, true, false, 4 };
            //foreach (var data in dataCollection)
            //{
            //    if (data.GetType().ToString().Contains("Boolean"))
            //    {
            //        Console.WriteLine(data);
            //    }                
            //}

            ////Task 22
            ////Code refactoring
            ////First way of implementing a list and write the data on the list to the console
            //List<string> names = new List<string>() { "Becky", "Ranti", "Sandra", "Enitan", "Theresa" };            
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine();
            ////Another way of implementing above code
            //new List<string>() { "Paul", "Ted", "Rooney", "Brandon", "Lola" }.ForEach(name => Console.WriteLine(name));

            //Console.WriteLine();
            ////Another way to implement the same code
            //List<string> studentNames = new List<string>() { "Balotelli", "Stone", "JayJay", "Raymond", "Sola" };
            //studentNames.ForEach(name => Console.WriteLine(name));

            ////Task 23
            ////Dictionary, as a collection, can be used to manage data with Key and Value.
            ////A Dictionary class is a data structure that represents a collection of keys and values pair of data
            ////Key  = Family
            ////Value = a group of one or more parents and their children living together as a unit
            ////Write a computer program to capture student names and their marks. 
            ////Display to the console all capture students along with their marks
            //Dictionary<string, int> studentMarks = new Dictionary<string, int>();
            //studentMarks.Add("Sandra", 70);
            //studentMarks.Add("Wonishi", 73);
            //studentMarks.Add("Howard", 68);
            //studentMarks.Add("Tesler", 37);
            //foreach (var studentMark in studentMarks)
            //{
            //    Console.WriteLine("Student " + studentMark.Key + " has a mark of " + studentMark.Value);
            //}

            ////Task 24
            ////Dictionary, as a collection, can be used to manage data with Key and Value.            
            ////Write a computer program to capture student names and their marks. 
            ////Display to the console only students with marks 70 and above
            //Dictionary<string, int> studentMarks = new Dictionary<string, int>();
            //studentMarks.Add("Sandra", 70);
            //studentMarks.Add("Wonishi", 73);
            //studentMarks.Add("Howard", 68);
            //studentMarks.Add("Tesler", 37);
            //studentMarks.Add("Becky", 71);
            //foreach (var studentMark in studentMarks)
            //{
            //    if (studentMark.Value >= 70)
            //    {
            //        Console.WriteLine("Student " + studentMark.Key + " has a mark of " + studentMark.Value);
            //    }                
            //}

            ////Task 25
            ////Dictionary, as a collection, can be used to manage data with Key and Value.            
            ////Write a computer program to capture student names and their marks. 
            ////Display to the console only students with marks between 40 and 70
            //Dictionary<string, int> studentMarks = new Dictionary<string, int>();
            //studentMarks.Add("Sandra", 70);
            //studentMarks.Add("Wonishi", 73);
            //studentMarks.Add("Howard", 68);
            //studentMarks.Add("Tesler", 37);
            //studentMarks.Add("Becky", 71);
            //studentMarks.Add("Richard", 40);
            //foreach (var studentMark in studentMarks)
            //{
            //    if (studentMark.Value >= 40 && studentMark.Value <= 70)  //|| OR-statement, && AND-statement
            //    {
            //        Console.WriteLine("Student " + studentMark.Key + " has a mark of " + studentMark.Value);
            //    }
            //}

            ////Task 26
            ////For-statement implementation
            ////Write a computer program to generate numbers between 1 and 20 to the console
            //for (int i = 1; i <= 20; i++)  //i++ means incremental
            //{
            //    Console.WriteLine(i);
            //}

            ////Task 27
            ////For-statement implementation
            ////Write a computer program to generate numbers between 1 and 20. Only print
            ////to the console all even number
            //for (int number = 1; number <= 20; number++)  //i++ means incremental
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }                
            //}

            ////Task 28
            ////While-statement implementation
            ////This can be used to loop through a set of data so as to meet a certain 
            ////condition. It is an option to for-statement
            ////Write a computer program to print "Happy Birthday" 10 times 
            ////Below is an option of using for-statement to answer above question
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i + " Happy Birthday" );
            //}
            ////Below is an option of using while-statement to answer above question
            //Console.WriteLine();
            //int counter = 1;
            //while (counter <= 10)
            //{
            //    Console.WriteLine(counter + " Happy Birthday");
            //    counter++;  //this is an incremental that will add 1 to the current each time
            //}

            ////Task 29
            ////Switch-case implementation
            ////This is also an option to an if-statement
            ////Write a computer program to allow a user to input a browser name so as to 
            ////decide a browser to use for test execution
            //Console.WriteLine("Input a browser name e.g. IE, Chrome, Firefox");
            //string browser = Console.ReadLine().ToLower();
            //switch (browser)
            //{
            //    case "ie":
            //        Console.WriteLine("Use IE browser for test execution");
            //        break;
            //    case "chrome":
            //        Console.WriteLine("Use Chrome browser for test execution");
            //        break;
            //    case "firefox":
            //        Console.WriteLine("Use Firefox browser for test execution");
            //        break;
            //    default:
            //        Console.WriteLine("Use Safari browser for test execution");
            //        break;
            //}

            ////Task 30
            ////Static class is a class type that won't allow you to create its object
            ////As oppose to an instance class which allows object creation
            //FirstClass firstClassObj = new FirstClass();  //this is an instance class
            //int age = Class1.age;  //Class1 is a static class which is why we are calling it directly
            //string name = Class1.name;
            //Class1.StudentDetails();

            //Task 31
            //Concept class level and method level variables
            //Create a new class 'Class2' to demonstrate it

            ////Task 32
            ////Concept of String manipulation in C sharp
            ////Write a computer program to allow a user to input a string value and assign 
            ////it to a variable 
            ////Use the declared variable for different things that is possible 
            ////while manipulating strings
            //Console.WriteLine("Input a text and press enter");
            //string text = Console.ReadLine();
            //Console.WriteLine(text.Contains("Lon")); //this gives back true/false
            //Console.WriteLine(text.Length); //this gives back the number of characters in the text
            //string textTake = text.Take(5).ToString();
            //Console.WriteLine(textTake); //this gives back the first 5 characters from the text
            //string textSkip = text.Skip(5).ToString();
            //Console.WriteLine(textSkip); //this skips the first 5 letters and write the remaining letters
            //string nextText = text.Clone().ToString();
            //Console.WriteLine(nextText);

            ////Task 33
            ////Read data from a Text (Notepad) file
            ////Write a computer program to read data from a text file to the console
            //Console.WriteLine(File.ReadAllText(@"DataReading.txt"));

            ////Task  34
            ////Write data to a Text file
            //File.WriteAllText(@"DataWriting.txt", File.ReadAllText(@"DataReading.txt"));

            ////Task 35
            ////Write a computer program to fetch data from 'Student' table within 'Test'
            ////database in SQL Server Management Studio and display those records to the 
            ////Console. 
            ////Prerequisites: you must have 'Test' database, 'Student' table
            ////and atleast 4 records on the 'Student' table
            //string connectionString = "Data Source=KOLADETIAMI19E6\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True;MultipleActiveResultSets=True";
            //List<StudentModel> fetchedRecords = SelectStudentRecords(connectionString);
            //foreach (var record in fetchedRecords)
            //{
            //    Console.WriteLine(record.StudentId + " " + record.FirstName + " " + 
            //                      record.LastName + " " + record.City);
            //}

            ////Task 36
            ////Write a computer program to populate data to 'Student' table within 'Test'
            ////database in SQL Server Management Studio.
            ////Prerequisites: you must have 'Test' database, 'Student' table
            ////and atleast 4 records on the 'Student' table
            ////To verify that you have populated a table as expected, you can execute lines 
            ////of code in Task 35 or goto SQL Server database system to execute a select 
            ////statement on the 'Test' database
            //string connectionString = "Data Source=KOLADETIAMI19E6\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True;MultipleActiveResultSets=True";
            //PopulateStudentTable(connectionString);

            //Task 37
            //Concept of Object Oriented Programming (OOP)


        }

        static void PopulateStudentTable(string connectionString)
        {
            string query = @"insert into Student(FirstName, LastName, City)
                             values('Olayinka', 'Lisa', 'London')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        static List<StudentModel> SelectStudentRecords(string connectionString)
        {
            List<StudentModel> studentRecords = new List<StudentModel>();
            string sqlQuery = "Select * from Student";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StudentModel record = new StudentModel();
                        record.StudentId = reader["StudentId"].ToString();
                        record.FirstName = reader["FirstName"].ToString();
                        record.LastName = reader["LastName"].ToString();
                        record.City = reader["City"].ToString();
                        studentRecords.Add(record);
                    }
                    connection.Close();
                }
            }
            return studentRecords;
        }

        static void FirstMethod()
        {
            Console.WriteLine("1. Happy New Year");
            Console.WriteLine("2. Happy New Year");
            Console.WriteLine("3. Happy New Year");
        }

        static void SecondMethod()
        {
            Console.WriteLine("4. Happy New Year");
            Console.WriteLine("5. Happy New Year");
            Console.WriteLine("6. Happy New Year");
        }

        static void ThirdMethod()
        {
            Console.WriteLine("7. Happy New Year");
            Console.WriteLine("8. Happy New Year");
            Console.WriteLine("9. Happy New Year");
        }
    }
}
