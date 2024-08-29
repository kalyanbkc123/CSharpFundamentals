using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    public class WhileLoop
    {

        static void Main(string[] args)
        {

            //1.example 
            /*
            int i = 0; // initialization 
           
            while (i < 10) // conditon 
            {
                Console.WriteLine("Value of i : {0}",i);

                i++; // increment/ decrement operator..
            }
            */

            //2. using break, return , continue in while loop
            /*
             int i = 0;

             while (true)
             {
                 Console.WriteLine("Value of i : {0}",i);

                 i++;

                 if (i >  10)
                 {
                     break;
                 }
             }
            */

            //3. Infinite While loop
            /*
            int i = 0;

            while (i > 0)
            {
                Console.WriteLine("Value of i :{0}", i);
                
                i++;

             }
            */

            //4. Nested While Loop

            int i = 0, j = 1;

            while (i < 2)
            {
                Console.WriteLine("Value of i : {0}",i);

                i++;

                while (j < 2)
                {
                    Console.WriteLine("Value of j : {0}", j);
                    j++;
                }
            }




            


        }
    }
}
