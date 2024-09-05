using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Collections
{
    internal class SortedList
    {
        static void Main(string[] args)
        { 
            SortedList<string, string> cities = new SortedList<string, string>()
            {
                {"London", "UK" },
                {"New York", "USA"},
                {"Mumbai", "India"}            
            };

            foreach (KeyValuePair<string, string> kvp in cities)
            {
                Console.WriteLine("key:  {0},  value:  {1}", kvp.Key, kvp.Value);
            }

            SortedList<int,string> numbers = new SortedList<int,string>();
            numbers.Add(1, "One");
            numbers.Add(4, "Four");
            numbers.Add(2, "Two");
            numbers.Add(3, "Three");
            

            foreach (KeyValuePair<int, string> kvp in numbers)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }

            // Adding new elemnts

            numbers.Add(5, "Five");
            numbers.Add(7, "Seven");
            numbers.Add(9, "Nine");

            foreach (KeyValuePair<int, string> kvp in numbers)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }

            // Access SortedList Values

            SortedList<int, string> numberNames = new SortedList<int, string>();

            numberNames.Add(1, "One");
            numberNames.Add(3, "Three");
            numberNames.Add(4, "four");

            foreach (KeyValuePair<int,string> item in numberNames)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
                  
            }


            // updating a value

            numberNames[1] = "thirty-four";
            numberNames[8] = "eighty-eight"; // Adds a new key value pair

            foreach (KeyValuePair<int, string> item in numberNames)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            // ContainsKey() and TryGetValue() methods...

            var res = numberNames.ContainsKey(1);
            Console.WriteLine(res);

            string val;
            if (numberNames.TryGetValue(1, out val))
            {
                Console.WriteLine("{0} {1}", 1, val);
            }

            // Iterate sorted list using for loop

            SortedList<int, string> namedList = new SortedList<int, string>();

            namedList.Add(1, "Number-one");
            namedList.Add(2, "Number-two");
            namedList.Add(3, "Number-three");
            namedList.Add(4, "Number-four");


            for (int i = 0; i < namedList.Count; i++)
            {
                Console.Write("Key : {0} Value : {1} ", namedList.Keys[i], namedList.Values[i]);
                Console.WriteLine();
            }

            // Remove(key) and RemoveAt(key)

            var list = new SortedList<string, string>()
            {
                {"one","first name"},
                {"two", "second name"},
                {"three", "third name"}
            };

            list.Remove("one");

            list.RemoveAt(0);

            foreach (var i in list)
            {
                Console.Write("Key {0} Value {1} ",i.Key, i.Value);
            }

            // using RemoveAt(key)

           

        }
    }
}
