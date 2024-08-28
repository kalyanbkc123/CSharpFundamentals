using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    public class TernaryOperator
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;

            var res = x > y ? "x is greater" : "y is greater";

            Console.WriteLine(res);

            // Nested Ternary Operator..
            int i = 100, j = 100;

            var res1 = i > j ? "i is greater" : i < j ? "j is greater" : i == j ? "i equals j" : "No result";
            Console.WriteLine(res1);

            int a = 3, b = 10, c = 15;

            var res2 = a * 3 > y ? a : b > c ? b : c; 

            Console.WriteLine(res2);

            
        
        }
    }
}
