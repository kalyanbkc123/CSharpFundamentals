using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.oops
{    
   
    // Aggregation relation
    // it is also has - a relation 
    // 

    class Student4
    {

        public int StudentId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public Course EnrolledCourse { get; set; }



    }

    class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public IList Topcis { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }



       
    }

    internal class Aggregration4
    {
    }
}
