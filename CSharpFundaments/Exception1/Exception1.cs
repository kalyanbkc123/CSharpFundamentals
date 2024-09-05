using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Exception1
{
    internal class Exception1
    {

        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Enter a number : ");

            var num = int.Parse(Console.ReadLine()); // FormatException..

            Console.WriteLine($"Square of number is {num * num}");
            */

            // Example: 1 : Exception Handling using Try Catch Blocks..

            /*
            try
            {
                Console.WriteLine("Enter a num : ");

                var num1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Square of number is {num1 * num1}");

            }

            catch(Exception ex)
            {
                Console.WriteLine("Error Occured.."+ ex.Message);

            }

            finally
            {
                Console.WriteLine("Re-try with a different number..");

            }

            */

            //====================================//
            /*
            try
            {

            int num = Convert.ToInt32(Console.ReadLine());

            int result = 100 / num;

            Console.WriteLine("divide 100 / {0} = {1}", num, result);

            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("cannot divide by zero please try agian..: "+ ex);

            }

            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Invalid Operation please try again.." + ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Invalid Foramt please use correct format.." + ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Occured Please try again.."  + ex);
            }

            */
            // Invalid Catch example 1
            /*  A program cannot have two catch blocks becuase it may give exceptions..
            try 
            {
                int num = 100 / 0;
            }

            catch
            {

            }
            catch (Exception)
            {

                throw;
            }
            */

            // finally block..
            /*
            FileInfo file = null;

            try
            {
                Console.WriteLine("Enter a file name: ");
                string fileName = Console.ReadLine();
                file = new FileInfo(fileName);
                file.AppendText();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occured : {0}", e);
            }

            finally
            {
                Console.WriteLine("finally executed..");
                file = null;
            }

            */

            // Nested try catch

            var divider = 0;

            try
            {
                try
                {
                    int val = 100 / divider;
                }
                catch (NullReferenceException)
                {

                    Console.WriteLine("Inner Catch.");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Outer Catch..");
            }

        }
    }
}
