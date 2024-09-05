using CSharpFundaments.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Exception1
{
    internal class throw1
    {
        static void Main(string[] arsg)
        {
            /*
            Student std = null;

            try
            {
                GetStudentDetails(std);


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static void GetStudentDetails(Student student)
        {
            if(student == null)
            {
                throw new NullReferenceException("Student is null..");
            }

            // Console.WriteLine((student.StuentName);

            Console.WriteLine("Student name is : ");

            */

            try
            {
                method1();

            }
            catch(Exception ex) {

                Console.WriteLine(ex.StackTrace);
            }
        }

        static void method1()
        {
            try
            {
                method2();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        static void method2()
        {

            string str = null;

            try
            {

                Console.WriteLine(str[0]);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
