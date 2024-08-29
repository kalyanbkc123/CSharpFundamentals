using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    public class SwitchExample
    {
        static void Main(string[] args)
        {
            // Example 1
            int x = 10;

            switch(x)
            {
                case 5: 
                    Console.WriteLine("the value is 5");
                    break;

                 case 10: 
                    Console.WriteLine("The value is 10");
                    break;

                default:
                    Console.WriteLine("default value");
                    break;
            }

            int x1 = 125;

            switch (x1 % 2)
            {
                case 1:
                    Console.WriteLine($"It is an odd value..{x1}");
                    break;
               
                case 0:
                    Console.WriteLine($"it is an even value.. {x1}");
                    break;
               
                default:
                    break;
            }

            //C# 7 onwards it includes non-unique values

            var statementType = "switch";

            switch (statementType)
            {
                case "if.else":
                    Console.WriteLine("It else condition");
                    break;
                case "ternary":
                    Console.WriteLine("ternary operation");
                    break;
               
                case "switch":
                    Console.WriteLine("switch operation..");
                    break;
                
               
            }

            // multiple conditons can be combined to execute single statement..
            var z = 5;
            switch (z) {

                case 1: Console.WriteLine("1");
                    break;
                case 2: Console.WriteLine("2");
                    break;
                case 3: Console.WriteLine("3");
                    break;
                case 4: Console.WriteLine("4 or 5");
                    break;
                default:
                    Console.WriteLine($"value is  > 5");
                        break;
            }

            // return in switch case..
            bool res = oddVal(70);
            Console.WriteLine(res);

            int j = 5;

            switch (j)
            {
                case 5:
                    Console.WriteLine(5);
                    switch (j - 1)
                    {
                        case 4:
                            Console.WriteLine(4);
                            switch (j - 2)
                            {
                                case 3:
                                    Console.WriteLine(3);
                                    break;
                            }
                            break;
                    }
                    break;
                case 10:
                    Console.WriteLine(10);
                    break;
                case 15:
                    Console.WriteLine(15);
                    break;
                default:
                    Console.WriteLine(100);
                    break;
            }


        }

        static bool oddVal(int x)
        {
            switch (x % 2)
            {
                case 0: return true;
                case 1:return false;

            }
            return false;
        }

        //Nested Switch Statements..



    }
}
