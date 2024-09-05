using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Collections
{
    internal class HashTable1
    {
        static void Main(string[] args)
        { 
            
            Hashtable numberNames = new Hashtable();

            numberNames.Add(1, "One");
            numberNames.Add(2, "two");
            numberNames.Add(3, "three");

            // numberNames.Add(3, "three-Capital.."); // Key already added.
            /*
            foreach (DictionaryEntry de in numberNames)
            {
                Console.WriteLine("Key : {0}, Value: {1}",de.Key, de.Value);
            }
            */

            // creating a hashtable using collection initializer syntax

            var table = new Hashtable()
            {
                {"UK", "UK-1, UK-2, UK-3"},
                { "USA", "USA-1, USA-2, USA-3"},
                { "FRANCE", "F-1, F-2" }
            };

            Console.WriteLine();
            /*
            foreach (DictionaryEntry de in table)
            {
                Console.WriteLine("Key : {0}, Value : {1} ", de.Key, de.Value);
            }

            */

            // Add Dictionary in Hash Table

            Dictionary<int, String> dt = new Dictionary<int, string>();
            dt.Add(1, "One");
            dt.Add(2, "two");
            dt.Add(3, "three");

            var dt1 = new Hashtable(dt);
            dt.Add(4, "four");

            Console.WriteLine();

            /*
            foreach (DictionaryEntry i in dt1)
            {
                Console.WriteLine("Key : {0}, Value :{1}", i.Key, i.Value);
            }

            */

            //------------------------------//
            // Update Hash Table
            /*
            var cityNames = new Hashtable()
            {
                {"USA", "New York, Kansas city, California"},
                {"UK", "England, new Hamshphire, Biringham"},
                {"France", "paris, italy"}
            };
            

            string citiesOfUSA = (string) cityNames["USA"];
            string citiesOfUk = (string) cityNames["ÜK"];

            Console.WriteLine(citiesOfUk);
            Console.WriteLine(citiesOfUSA);

            cityNames["UK"] = "England, UK-2"; // update key of UK
            cityNames["USA"] = "New York, KC, Seattle"; // update key of USA

            if (!cityNames.ContainsKey("France"))
            {
                cityNames["France"] = "Pairs";
            }

            */
            /*
            foreach(DictionaryEntry de in cityNames)
            {
                Console.WriteLine("Key : {0}, value : {1}",de.Key, de.Value);
            }
            */

            // Remove Elements from HashTable

            var cities = new Hashtable()
            {
                {"USA", "Kansas city, New York, Fort Wayne"},
                {"UK", "New England, Port Wayane"}
            };

            cities.Remove("USA");


            if (!cities.ContainsKey("France"))
            {
                cities["France"] = "Paris, Italy.";
            }

            cities.Clear();

            foreach(DictionaryEntry de in cities)
            {
                Console.WriteLine("Key {0}, Value : {1}",de.Key, de.Value);
            }

        }

    }
}
