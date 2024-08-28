using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals

{

    public class Studnet
    {
        public void displayStudentInfo(int id)
        { 
        }
    }

    public class DynamicType
    {
        static void Main(string[] args)
        {   
            // dynamic variable
            dynamic var = 1;
            // dynamic variabl at runtime
            Console.WriteLine(" {0}, {1}",var,var.GetType());

            // dynamic variable at runtime

            dynamic var1 = 1;
            Console.WriteLine("{0}, {1}", var1, var1.GetType());

            dynamic var2 = "Hello World";
            Console.WriteLine("{0}, {1}", var2, var2.GetType());

            dynamic var3 = true;
            Console.WriteLine("{0} {1}",var3, var3.GetType());

            dynamic var4 = DateTime.Now;
            Console.WriteLine("{0} {1}",var4, var4.GetType());

            // Implicit Conversion of Dynmaic Type
            dynamic d1 = 4;
            int i = d1;

            d1 = "Hello!..";
            string s = d1;

            d1 = DateTime.Now;
            DateTime time = d1;

            Console.WriteLine(time);

            // dynamic 

            dynamic student = new Studnet();
            // we will not get compile time error but we will get RunTime Exception..
            student.displayStudentInfo(1);
            student.displayStudentInfo(1, "Bill Gates"); // RunTimeException
            student.fakeStudent();  


            


        }
        
    }
}
