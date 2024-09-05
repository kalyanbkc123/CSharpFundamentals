using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpFundaments.Exception1
{
    class Student
    {
        public int studentId { get; set; }
        public string name { get; set; }


    }

    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }

        public InvalidStudentNameException(string name) :

            base(String.Format("Invalid Studnet Name {0} ", name))

        {
        }

    }

    class Program1
    {
        static void Main(string[] args)
        {
            Student newStudent = null;


            try
            {

                newStudent = new Student();
                newStudent.name = "John007";

                validateStudent(newStudent);

            }
            catch (InvalidStudentNameException ex)
            {

                Console.WriteLine(ex.StackTrace);
            }

            static void validateStudent(Student student)
            {
                Regex reg = new Regex("^[a-zA-Z]+$"); ;

                if (!reg.IsMatch(student.name))
                {
                    throw new InvalidStudentNameException(student.name);
                }
            }


        }
    }

}
        
    
    

    


