using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.oops
{
    class Student
    {
        private string _firstName;

        public string FirstName { get; set; }

        private string _lastName;

        public string LastName { get; set; }

        private string _middelName;

        public string MiddelName { get; set; }

        private string _fullName;

        public string FullName
        {
            get { return _firstName + " " + LastName;  }
        }
        

        public void save()
        {

        }

        public void subscribe()
        {
            verify();
        }

        public void verify()
        {

        }

        public void getSubscribedCourses()
        {

        }

    }
                                            

    internal class Encapsulation1
    {    

       static void Main(string[] args)
        {

        }
    }
}
