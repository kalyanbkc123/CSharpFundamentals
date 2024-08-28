using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    public class IfElseStatements
    {
        static void Main(string[] args)
        {
            // If statement 
            // if(condition) condition must be a boolean value either true or false..

            int i = 9, j = 10;
            if (i < j)
            {
                Console.WriteLine("the value of i is less than j..");
            }
            else
            {
                Console.WriteLine("the value of j is less than i..");
            }

            // wrong statement example..
            /*
            if (i + 1)
            {
                Console.WriteLine("compile time error..");
            }
            if(i  + j)
            {
                Console.WriteLine("compiler time error..");
            }
            */


            /*
            static bool isGreaterValue(int i, int j)
            {
                return i > j;
            }

            if (isGreaterValue(i, j))
            {
                Console.WriteLine("i is greater..");
            }
            if (isGreaterValue(j, i))
            {
                Console.WriteLine("j is greater..");
            }
            */

            //else-if statement
            /*
            if (i == j)
            {
                Console.WriteLine("i value is equal to j");
            }
            else if (i < j)
            {
                Console.WriteLine("i value is less than j");
            }
            else if(i > j )
            {
                Console.WriteLine("i value is greater than j");
            }
            */

            // if else-if else 
            /*
            if (i > j)
            {
                Console.WriteLine("i is greater..");
            }
            else if (i == j)
            {
                Console.WriteLine("i == j");
            }
            else
            {
                Console.WriteLine("j is greater...");
            }
            */

            // Nested If statements
            if (i != j)
            {
                Console.WriteLine("j is greater..");
                if (i < j)
                {
                    Console.WriteLine("j is greater..");
                }
                else
                {
                    Console.WriteLine("Never executed");
                }
            }
            else
            {
                Console.WriteLine("is is equal to j");
            }



            
        }
    }
}
