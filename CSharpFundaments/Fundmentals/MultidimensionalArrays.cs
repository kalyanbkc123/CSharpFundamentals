using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    public class MultidimensionalArrays
    {
        static void Main(string[] args)
        {

            //1. Declaring and initializing multi-dimensional arrays

            int[,] arr2d = new int[3,2] {
                            {1,2},
                            { 3,4},
                            { 5,6}

            };

            // other way of declaring the array..

            int[,] num2d = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            // Access two-dimensional array

            int[,] array2d = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine(array2d[0,0]);
            Console.WriteLine(array2d[0,1]);
            Console.WriteLine(array2d[1,0]);
            Console.WriteLine(array2d[1,1]);
            Console.WriteLine(array2d[2,0]);
            Console.WriteLine(array2d[2,1]);

            //int[,,] array3d = new int[1, 1, 2] {
            //                    { {1,2},{3,4} }
            //};

            int[,,] arr3d2 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } }; // 2 rows of two dimensional arrays

            int[,,] arr3d3 = new int[2, 2, 3]
                {   { { 1,2,3}, { 4,5,6} },
                { { 5, 6,7, },{8,9,10 } }
                }; // 2 rows of two dimensional arrays..


            Console.WriteLine("arr3d2 values: ");
            Console.WriteLine(arr3d2[0,0,0]);
            Console.WriteLine(arr3d2[0,0,1]);
            Console.WriteLine(arr3d2[0,1,0]);
            Console.WriteLine(arr3d2[0,1,1]);
            Console.WriteLine(arr3d2[1,0,0]);
            Console.WriteLine(arr3d2[1,0,1]);
            Console.WriteLine(arr3d2[1,1,0]);
            Console.WriteLine(arr3d2[1,1,1]);
            
                   
        }

    }
}
