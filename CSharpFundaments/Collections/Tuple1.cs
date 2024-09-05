using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Collections
{
    internal class Tuple1
    {
        static void Main(string[] args)
        {
            Tuple<int, string, string> t1 = new Tuple<int, string, string>(1, "John", "Mosses");

            // other ways to create the tuple

            var t2 = Tuple.Create("ravi", "string", 1, 2, 3);

            // Accessing Tuple Elements

            var t3 = Tuple.Create(1, 2, "Name1", "Name4", "Name5");

            Console.WriteLine(t3.Item1);
            Console.WriteLine(t3.Item2);
            Console.WriteLine(t3.Item3);
            Console.WriteLine(t3.Item4);
            Console.WriteLine(t3.Item5);

            // Nested Tuples..
            //the tuple when placed in the last element can be accesed by Rest:  Rest.Item1.Item<elementNumber>

            var t4 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create("A", 1, 3.4, "B"));

            Console.WriteLine(t4.Item1);
            Console.WriteLine(t4.Item2);
            Console.WriteLine(t4.Item3);
            Console.WriteLine(t4.Rest.Item1);
            Console.WriteLine(t4.Rest.Item1.Item1);
            Console.WriteLine(t4.Rest.Item1.Item2);

            // Nested Tuple Ex:2 
            // It can contain atmost 8 elements..

            var t5 = Tuple.Create(1, 2, 3, 4, 5, Tuple.Create("A", "B", 1, 45,67), 12, 13);

            Console.WriteLine(t5.Item1);
            Console.WriteLine(t5.Item2);
            Console.WriteLine(t5.Item3);
            Console.WriteLine(t5.Item4);
            Console.WriteLine(t5.Item5);
            Console.WriteLine(t5.Item6);
            Console.WriteLine(t5.Item6.Item1);
            Console.WriteLine(t5.Item6.Item2);
            Console.WriteLine(t5.Item6.Item3);

            Console.WriteLine(t5.Rest.Item1);

            // Tuple as method parameter

            var person = Tuple.Create(1, "John", "Woo");

            displayPerson(person);

            // Tuple as return Type

            var person1 = getPerson();

            Console.WriteLine($"id : {person1.Item1}");
            Console.WriteLine($"First Name : {person1.Item2}");
            Console.WriteLine($"Last Name : {person1.Item3}");
    }

        static void displayPerson(Tuple<int, string, string> person)
        {
            Console.WriteLine($" id : {person.Item1}");
            Console.WriteLine($" First Name : {person.Item2}");
            Console.WriteLine($" Last Name: {person.Item3}");
        }

        static Tuple<int, string, string> getPerson()
        {
            return Tuple.Create(1, "John", "Wick");
        }

    }
}
