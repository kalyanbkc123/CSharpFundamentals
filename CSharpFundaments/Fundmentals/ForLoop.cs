using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    public class ForLoop
    {
        static void Main(string[] args)
        {

            //1. example 1
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i :{0}", i);

            }
            */

            //2. example 2
            // initialization, condition, inc/dec operatos are optional..
            /*
            int i = 0;

            for (; ; )
            {
                if (i < 10)
                {
                    Console.WriteLine("Value of i : {0}", i);
                    i++;
                }
                else {
                    break;
                }
            }
            */

            //3. example 3
            // Infinite for Loop
            /*
            for (; ; )
            {
                Console.Write(1);
            }
            */

            //4. Decimal for Loop
            // the control vairalbe forthe for loop can be any numberic datatype,
            // such as double, decimal, etc
            /*
            for (double d = 1.01D; d < 1.10; d += 0.01D)
            {
                Console.WriteLine("Value of i : {0}",d);
            }
            */

            //5. Reverse for loop
            /*
            for(int i = 10; i >0; i--)
            {
                Console.WriteLine("Value of i : {0}", i);
            }
            */

            //6. break in for loop
            // you can also exit from a for loop by using the break keyword..
            /*
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine("Value of i : {0}", i);
            }
            */

            //7. Multiple Expressions
            /*
            for (int i = 0, j = 0; i + j < 5; i++, j++)
            {
                Console.WriteLine("Value of i : {0}, J: {1}",i,j);
            }
            */

            //8. A for loop can also contain statements as an initializer and iteraotr
           
            int i = 0, j = 5;
            for (Console.WriteLine($"Initializer : i = {i}, j = {j}");
                i++ < j--;
                Console.WriteLine($"Iterator: i = {i}, j ={j}"))
            { 
            
            }
           

            //9. Nested for loop
            /*
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Value of i :{0}, J : {1}", i, j);
                    
                }
            }
            */


         

        
        
        }

    }
}
