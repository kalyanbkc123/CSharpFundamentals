using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{

    public class MyClass
    { 
    
        public Nullable<int> id;
    }
    public class NullableTypes
    {
        static void Main(string[] args)
        {

            //1. normal value range + the null value
            Nullable<int> i = null;

            if (i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
            else {
                Console.WriteLine("Null");
            }

            // GetValueOrDefault

            Console.WriteLine(i.GetValueOrDefault());

            // Shorthand Synatx for Nullable Types
            int? k = null;
            int j = k ?? 8; // check if k is compatiable if not it will assign the value beside it..
            Console.WriteLine(j);

            MyClass myClass = new MyClass();

            if (myClass.id == null)
            {
                Console.WriteLine("Null");
            }

            // Nullable Helper Class..
            int? l = null;
            int m = 10;

            if (l < m)
            {
                Console.WriteLine("l <  m");
            }
            else if (l > m)
            {
                Console.WriteLine("l > m ");
            }
            else if (l == 10)
            {
                Console.WriteLine("l = 10");
            }

            else
            {
                Console.WriteLine("could not compare");
            }

            // Use static Nullabe class for comaprison

            if (Nullable.Compare<int>(i, j) < 0)
            {
                Console.WriteLine("i < j");
            }
            else if (Nullable.Compare<int>(i, j) > 0)
            {
                Console.WriteLine("i > j");

            }
            else
            {
                Console.WriteLine("i = j");
            }








        
        }

    }
}
