using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Collections
{
    class Program1
    {
        static void Main(string[] args)
        {
            // create an arraylist

            ArrayList arList = new ArrayList();

            // or
            var arlist1 = new ArrayList(); // recommended..

            // Adding Elements in ArrayList

            // Use the Add() method

            // It can contain multiple null and duplicate values..

            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add("");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            // adding elements using object initializer syntax

            var arlist2 = new ArrayList()
                    {
                      2 ,"Steve", " ", true, 4.5, null
                    };

            foreach (var ar in arlist2)
            {
                Console.WriteLine(ar);
            }

            // Example : Adding Entire Array// ArrayList into ArrayList

            var arlist3 = new ArrayList();

            var arlist4 = new ArrayList()
            {
                1, "Bill", " ", true, 4.5, null
            };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist3.AddRange(arlist4); // adding arraylist in arraylist
            arlist3.AddRange(arr); // adding array in arraylist
            arlist3.AddRange(myQ); // adding queue in arraylist

            foreach (var ar in arlist3)
            {
                Console.WriteLine(ar);
            }

            // Accesing Elements of ArrayList

            var arlist5 = new ArrayList()
            {
                1, "Bill", 300, 4.5f
            };

            // Access individual item using indexer
            int firstElement = (int)arlist5[0];
            Console.WriteLine(firstElement);
            string secondElement = (string)arlist5[1];
            Console.WriteLine(secondElement);

            // int thirdElement = (int)arlist5[1];   // InvalidCast Exception..

            // using var keyword without explicit casting
            var oneEle = arlist5[0];
            Console.WriteLine(oneEle);
            var secEle = arlist5[1];
            Console.WriteLine(secEle);
            //  var fifEle = arlist5[5]; //ArgumentOutOfRangeException..
            //Console.WriteLine(fifEle);

            //update Elements

            arlist5[0] = "Steve";
            arlist5[1] = 100;

            //Iterate ArrayList

            ArrayList list = new ArrayList()
            {
                1, "Bill", 300, 4.5F

            };

            foreach (var ar in list)
            {
                Console.Write(ar + ", ");
            }

            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ", ");
            }


            // Insert Element in ArrayList

            var list1 = new ArrayList()
            {
                1, "Bill", " ", true, 4.5


            };

            // void insert(int index, Object value)

            list1.Insert(1, "Second Time");

            foreach (var val in list1)
            {
                Console.WriteLine(val + ", ");
            }

            // Insert Collection in an arrayList

            var listA = new ArrayList() {
                    100, 200, 300 };

            var listB = new ArrayList() {
                 400,500,600 };

            listA.InsertRange(1, listB);

            foreach (var value in listA)
            {
                Console.Write(value + ", "); // 100, 400, 500, 600, 200, 300
            }

            //-------------------------------------//
            // Remove Element in ArrayList

            var listC = new ArrayList() {
                1,
                200,
                "bill",
                null,
                " ",
                4.5f,
                300
                };


            listC.Remove(null); // removes the first occurence of null..

            Console.WriteLine(listC);


            listC.RemoveAt(2); //1, 200, null, " ", 4.5f, 300

            listC.RemoveRange(0, 3);

            //check for elements...
            // use Contains().. method..
            var list6 = new ArrayList()
            {
                1,
                "Ravi",
                "Bojsmp",
                "kapella.."

            };

            Console.WriteLine(list6.Contains(1));
            Console.WriteLine(list6.Contains("Ravi"));
            Console.WriteLine(list6.Contains("Bojsmp"));
            Console.WriteLine(list6.Contains("kapella"));
            Console.WriteLine(list6.Contains(5));

        }
    }

}
