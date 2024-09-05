using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Collections
{
    internal class ValueTuple1
    {
        static void Main(string[] args)
        {
            // value Tuple initialization

            ValueTuple<int, string, string> tup1 = (1, "Bill", "Gates");
            Console.WriteLine(tup1.Item1);
            Console.WriteLine(tup1.Item2);
            Console.WriteLine(tup1.Item3);

            var tup2 = (1, "Bill1", "Gates1", "Ravi2", "Kishore2");

            Console.WriteLine(tup2.Item1);
            Console.WriteLine(tup2.Item2);
            Console.WriteLine(tup2.Item3);
            Console.WriteLine(tup2.Item4);
            Console.WriteLine(tup2.Item5);

            (int, string, string, int) tup3 = (1, "abc", "def", 6);

            Console.WriteLine(tup3.Item1);
            Console.WriteLine(tup3.Item2);
            Console.WriteLine(tup3.Item3);

            // tuple requires atlest two values

            var v1 = (1); // int type, not a tuple  
            var v2 = (1, 2); // valid tuple

            // unlike tuple and value tuple can hold more than 8 values

            var v3 = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            Console.WriteLine(v3);

            // Named members
            // assing names on the left

            (int Id, String FirstName, string LastName) named1 = (1, "Raghu", "Babu");

            Console.WriteLine(named1.Id);
            Console.WriteLine(named1.FirstName);
            Console.WriteLine(named1.LastName);

            // assign names on the right..

            var named2 = (Id: 1, FirstName: "Ravi", LastName: "Babu");
            Console.WriteLine(named2.Id);
            Console.WriteLine(named2.FirstName);
            Console.WriteLine(named2.LastName);

            // left has most precedence over the right precedence..

            (int Id, string FirstName, string LastName) named3 = (IdNo: 1, FirstName: "Babu", LastName: "Sir");

            Console.WriteLine(named3.Id);
            Console.WriteLine(named3.FirstName);
            Console.WriteLine(named3.LastName);

            // We can assign variables as value members

            string firstName = "Ravi";
            string lastName = "Babu";


            var named4 = (Id: 1, FirstName: firstName, LastName: lastName);

            Console.WriteLine(named4.Id);
            Console.WriteLine(named4.FirstName);
            Console.WriteLine(named4.LastName);

            // Value Tuple as Parameter..

            DisplayTuple((1, "FirstName", "LastName"));

            // Value Tuple as Return Type

            var person1 = GetPerson();

            Console.WriteLine("{0} {1} {2}", person1.Item1, person1.Item2, person1.Item3);

            // Deconstruction

            // Individual members of value tuple can be retrived by reconstructing it..
            // a deconstructnig syntax helps valueTuple into parts and indiviudal variables we can also change names.

           (int Id, string FirstName1, string LastName1) =  GetPerson1();

            Console.WriteLine(Id);
            Console.WriteLine(FirstName1);
            Console.WriteLine(LastName1);





        }

        static void DisplayTuple((int, string, string) person)
        {
            Console.WriteLine("{0} {1} {2} ", person.Item1, person.Item2, person.Item3);
        }

        static (int, string, string) GetPerson()
        {
            return (1, "firstname", "last name");
        }

        static (int, string, string) GetPerson1()
        {
            return (Id :1, FirstName : "FName",  LastName: "LName");
        }



    }
}
