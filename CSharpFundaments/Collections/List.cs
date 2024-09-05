using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Collections
{

    class Student
    {
        int Id;
        string name;

       
    }
    internal class List
    {
        static void Main(string[] args)
        {
            // Adding element in a List

            List<int> primeNumbers = new List<int>();

            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);
            primeNumbers.Add(13);

            foreach (int i in primeNumbers)
            {
                {
                    Console.WriteLine("The elements is {0}", i);
                }
            }

            Console.WriteLine();

            List<string> cities = new List<string>();

            cities.Add("Seattle");
            cities.Add("London");
            cities.Add("Kansas City");
            cities.Add("California");

            foreach(var city in cities)
            {
                Console.WriteLine(city);
            }

            // addding elements using collection - initializer syntax

            var names = new List<string>()
            {
                "ravi",
                "ramu",
                "raghu",
                "ram",
                "rajan"

            };

            Console.WriteLine();

            foreach(var name in names) {

                Console.Write(name + " ");
            }

            // Add customs objects in the list
            /*
            var student = new List<Student>()
            {
                new Student(){Id =1, name = "RAvi"},
                new Student(){Id=2, name = "raghu"}

            };
            */

            // Adding an Array in a List

            string[] cityNames = new string[] { "Mumbai", "London", "New York"};

            var popularCities = new String[]
                {
                    "New York",
                    "New Jersery",
                    "Binghamton"
                };
            
            var newList = new List<string>();

            newList.AddRange(cityNames);
            newList.AddRange(popularCities);

            Console.WriteLine();

            foreach (var city in newList)
            {
                Console.WriteLine(city + "");
            }

            // Accessing List

            List<int> numbers =  new List<int>() { 1,2,3,4,5,6,7,8,};

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            // Using LINQ queries

            numbers.ForEach(num => Console.Write(num + ", "));

            // using for loop

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //================================//

            // Insert Elements into the List

            numbers.Insert(3, 34);

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            //bool Remove(T item)
            // void RemoveAt(int index)

            numbers.Remove(1);

            numbers.ForEach(num => Console.Write(num + " "));

            numbers.RemoveAt(2);

            Console.WriteLine();

            numbers.ForEach(num => Console.Write(num + " "));

            // contains method

            var res = numbers.Contains(1);
            Console.WriteLine(res);


            
        }
    }
}

