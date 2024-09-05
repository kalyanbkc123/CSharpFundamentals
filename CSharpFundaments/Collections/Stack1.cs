using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Collections
{
    internal class Stack1
    {
        static void Main(string[] args)
        {
            // Create And Add Elements in the Stack

            Stack<int> nums = new Stack<int>();

            nums.Push(1);
            nums.Push(2);
            nums.Push(3);
            nums.Push(4);

            /*
            foreach (var item in nums)
            {
                Console.WriteLine(item  + ", ");
            }
            */

            // Create and Add Elements in the stack

            int[] arr = new int[] { 2, 4, 6, 7, 8, 9 };

            var arr1 = new Stack<int>(arr);
            /*
            foreach (var item in arr1)
            {
                Console.WriteLine(item + ", "); 
            }
            */

            // Peek() 

            var arr2 = new Stack<int>();

            arr2.Push(3);
            arr2.Push(2);
            arr2.Push(5);
            arr2.Push(7);

            while (arr2.Count > 0)
            {
                {
                    Console.WriteLine(arr2.Pop() + ", ");
                }
            }
        }
    }
}
