using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Collections
{
    internal class Queue1
    {
        static void Main(string[] args)
        {
            Queue<int> callerIds = new Queue<int>();

            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);
            callerIds.Enqueue(5);
            callerIds.Enqueue(6);

            Console.WriteLine("Total Elements: "+callerIds.Count);

            while (callerIds.Count > 0)
            {
                Console.WriteLine(callerIds.Dequeue());
            }


            Console.WriteLine("The Number of Elements are : "+callerIds.Count);

            // The Peek() method always returns teh first element in the queue, without removing it..
            // If the Peek() method is applied upon an empty queue, It will return InvalidOperationException..

            Queue<string> words = new Queue<string>();

            words.Enqueue("H");
            words.Enqueue("E");
            words.Enqueue("L");
            words.Enqueue("L");
            words.Enqueue("O");

            Console.WriteLine("Total Elements are : "+ words.Count);

            if (words.Count > 0)
            {

                Console.WriteLine("The Top Element is : " + words.Peek());
                Console.WriteLine("The Next Top Element is : " + words.Peek());

            }

            Console.WriteLine("The Count of Elemtns is " + words.Peek());

            // contains() method checks whether the element exists or not..

            bool res1 = words.Contains("A");
            Console.WriteLine(res1);

            bool res2 =  words.Contains("O");
            Console.WriteLine(res2);

        }
    }
}
