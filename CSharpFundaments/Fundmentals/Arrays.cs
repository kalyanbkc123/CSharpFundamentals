using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    public class Arrays
    {
        static void Main(string[] args)
        {
            //Example: Array Delcaration..
            /*
            int[] evenNums; // integer Array

            string[] cities; // string array
            */
            // Array declaration & Initialization

            int[] evenNums = new int[5] { 2, 4, 6, 8, 10 };

            string[] cities = new string[3] { "Mumbabi", "London", "New York" };

            // Array Declaration using var

            var evenNo = new int[4] { 2, 4, 6, 8 };
            var cities2 = new string[3] { "calciult", "seattle", "bay area.." };

            // Short syntax of array declaration

            int[] evenNums1 = { 2, 4, 6, 8, 10 };

            string[] cities1 = { "mumbabi", "London", "New York" };

            // Late Initialization

            int[] evenNums3;

            //evenNums3 = new int[5];

            //or 

            evenNums3 = new int[] { 2, 4, 6, 8, 10 };

            // Accessing Array Elements

            int[] arr = new int[5];
            arr[0] = 2;
            arr[1] = 4;
            // arr[6] = 6; // System.IndexOutOfRangeException..

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);

            /*
            // Accessing Array Elements using for loop
            // */
            /*
            int[] arr1 = { 1, 2, 3, 4, 56, 7, 8 };

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr1[i] + 10;
            }
            */
            /*
             * Accessing Array using foreach Loop
             */

            int[] nums = { 2, 4, 6, 8, 10 };
            string[] cities3 = { "Mumbai", "London", "New York" };

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            foreach (var city in cities3)
            {
                Console.WriteLine(city);
            }

            //=================//

            // LINQ Method 

            int[] kal = new int[5] { 10, 5, 16, 8, 6 };

           var max =  kal.Max();
            var min = kal.Min();
            var sum = kal.Sum();
           var avg=  kal.Average();

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
             Console.WriteLine(avg);

            // Array Methods

            int[] numbers = new int[5] { 10, 15, 16, 8, 6 };

            Array.Sort(numbers);
            Array.Reverse(numbers);
            Array.ForEach(numbers, x => Console.WriteLine(x));
            Array.BinarySearch(numbers, 5);


            // Passing Array as Argument

            int[] number3 = new int[6]{ 10, 9, 8, 7, 6, 5 };

            UpdateArray(nums);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }        
           
        }

        public static void UpdateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += arr[i] + 10;


            }
        
        }
    }
}
