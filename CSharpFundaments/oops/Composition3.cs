using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.oops
{   
    // Composition means it has-a relation..

    // class are dependent of each other
    // if the student object is deletd, then the address object is deleted..

    class Student2
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public Address HomeAddress;

    }

    public class Address
    {
        public int AddressId { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        

        public string ZipCode { get; set; }

        public string Country { get; set; }


    }

    // Composition using Address Id

    class Student3
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public int AddressId { get; set; }

    }



    internal class Composition3
    {
    }
}
