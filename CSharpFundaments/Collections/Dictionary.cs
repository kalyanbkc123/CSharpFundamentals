using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Collections
{
    internal class Dictionary
    {

        static void Main(string[] args)
        { 
            IDictionary<int, string> numberNames = new Dictionary<int, string>();

            numberNames.Add(1, "one");
            numberNames.Add(3, "three");
            numberNames.Add(2, "two");
            numberNames.Add(5, "five");
            numberNames.Add(4, "four");

            foreach (KeyValuePair<int, string> pair in numberNames)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }


            // uisng collection initializer syntax

            var names = new Dictionary<string, string>()
            {
                {"city", "hyderbad, Mohali, Delhi" },
                {"state", "ts, ap, tn" }

            };

            foreach (var name in names)
            {
                Console.WriteLine("Key : {0}, Value : {1}", name.Key, name.Value);
            }

            //===========================//

            // Access Dictionary Elements..

            var cities = new Dictionary<string, string>()
            {
                { "UK", "London, Branghamton, Biringham"},
                { "USA", "New York, Florida, Atlanta"},
                { "Australia", "Melbournce, Sydney"}
            };

            Console.WriteLine(cities["UK"]); // display value of UK
            Console.WriteLine(cities["USA"]); // display value of USA
            // Console.WriteLine(cities["France"]); // KeyNotFoundException.

            // Use ContainsKey() to check for unknown key

            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            // Use ElementAt() to retrive key-value pair using index

            for (int i = 0; i < numberNames.Count; i++)
            {
               Console.WriteLine("Key : {0} Value : {1}", numberNames.ElementAt(i).Key, numberNames.ElementAt(i).Value);
            }

            cities["UK"] = "Lodon, new london";
            cities["USA"] = "New York, Hamsphire, Kansas City";
            cities["France"] = "paris";
            cities["dubai"] = "abu-dharbi";

            foreach (var i in cities)
            {
                Console.WriteLine(i.Key, i.Value);
            }

            Console.WriteLine();

            cities.Remove("Japan");

            cities.Remove("France");

            if (cities.ContainsKey("USA"))
            {
                cities.Remove("USA");
            }

            foreach (var i in cities)
            {
                Console.WriteLine("Key : {0}, Value: {1}",i.Key, i.Value);
            }

            cities.Clear();

            Console.WriteLine(cities.Count);




















        }
        

        


    }
}
