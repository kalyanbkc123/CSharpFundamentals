using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    public class JaggedArray
    {

        static void Main(string[] args)
        {
            // Example : Jagged Arrays
            int[][] arr1 = new int[2][];  // It stores two single dimensional arrays.

            // It stores two single dimensional arrays.

            int[][,] arr2 = new int[2][,]; // It stores two two-dimensional arrays.

            // Accessing Jagged Arrays.

            arr1[0] = new int[3] { 1, 2, 3 };
            arr1[1] = new int[4] { 3,4,5,8};

            // jagged array initialization and declaration
            /*
            int[][] arr3 = new int[3][]
                {
                    new int[4]{ 3,4,5,6},
                    new int[5]{ 3,4,5,6,7},
                    new int[6]{ 1,2,3,4,5,6}
                };

            Console.WriteLine(arr3[0][1]); // 4
            Console.WriteLine(arr3[0][2]); // 5
            Console.WriteLine(arr3[0][3]); // 6
            Console.WriteLine(arr3[1][3]); // 6
            Console.WriteLine(arr3[2][5]); // 6
            */
            // you can access jagged array using two for loops
            /*
            Console.WriteLine();

            int[][] arr4 = new int[3][]
                {
                    new int[3]{ 1,2,3},
                    new int[4]{ 6,7,8,9},
                    new int[5]{ 9,8,7,6,5}
                };

            for (int i = 0; i < arr4.Length; i++)
            {
                for (int j = 0; j < arr4[i].Length; j++)
                {
                    Console.WriteLine(arr4[i][j]);
                }
                Console.WriteLine();
            }

            */

            //===========================================//

            // Two dimensional arrays
            /*
            int[][,] arr5 = new int[2][,];

            arr5[0] = new int[3, 2] { { 1, 2, }, { 3, 4 }, { 5, 6 } };
            arr5[1] = new int[2, 2] { { 12, 13 }, { 14, 15 } };

            Console.WriteLine(arr5[0][0,0]);
            Console.WriteLine(arr5[1][1,1]);
            */
            // Array of Array

            int[][][] arr6 = new int[2][][]
                            {
                                new int[2][]
                                { 
                                    new int[2]{1,2},
                                    new int[3]{4,5,6}
                                
                                },

                                new int[3][]
                                { 
                                    new int[1]{1},
                                    new int[2]{ 4,5},
                                    new int[3]{ 7,8,9}                                
                                }
                            };

            for (int i = 0; i < arr6.Length; i++)
            {
                for (int j = 0; j < arr6[i].Length; j++)
                {
                    for (int k = 0; k < arr6[i][j].Length; k++)
                    {
                        Console.WriteLine(arr6[i][j][k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


           





            

        
        }
    }
}
