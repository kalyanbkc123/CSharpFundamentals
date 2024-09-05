using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.oops
{
    // Associaton (uses-A) relation..

    class Student1
    {
        public int StudentId { get; set; } 
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; } 


    }

    class Student1Repository
    {
        public Student GetStudent(int studentId)
        {
            // get student by id from db here
            return new Student();
        }

        public bool save(Student student)
        { 
            // save the student to db here
            return true;
        }

        public bool validate(Student student)
        {
            // get student from db and check whether the data is exist or not 

            Console.WriteLine("Student does not exist..");

            return true;
        }
    }


    internal class Association2
    {


    }
}
