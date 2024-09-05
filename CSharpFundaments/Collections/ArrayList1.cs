using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpFundaments.Collections
{
    public class ArrayList1
    {
        static void Main(string[] args) 
        { 
            // Add and AddRange() Methods..

            ArrayList arrayList1 = new ArrayList();

            arrayList1.Add("The ");
            arrayList1.Add("Quick ");
            arrayList1.Add("Silver ");
            arrayList1.Add("Value term");

            Queue myQueue = new Queue();
            myQueue.Enqueue("first ");
            myQueue.Enqueue("second");
            myQueue.Enqueue("third");
            myQueue.Enqueue("fourth");
            myQueue.Enqueue("fifth");

            // the arraylist is 
            Console.WriteLine("the arraylist1 contents before adding the element is : "+ arrayList1);

            // the queue contenet is

            Console.WriteLine("queue contents are : " + myQueue);

            arrayList1.AddRange(myQueue);

            Console.WriteLine("AFter adding queue the values are:- ");

            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }


        }

    }
}
