using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    internal class DoWhileLoop
    {

        static void Main(string[] args)
        {

            //1. example 1
            /*
            int i = 0;

            do {

                Console.WriteLine("Value of i : {0}",i);
                i++;
            }while (i < 5);
            */

            //2. using break, return, continue in do while loop
            /*
            int i = 0;
            do {

                Console.WriteLine("Value of i : {0}", i);
                i++;

                if (i > 5)
                {
                    break;
                }
            }while (i < 10);
            */

            //3. Nested do while loop

            int i = 0, j = 1;
            do
            {

                Console.WriteLine("Value of i : {0}",i);
                i++;

                do
                {
                    Console.WriteLine("Value of j : {0}", j);
                    j++;

                } while (j < 2);


            } while (i < 2);


        
        }
    }
}
