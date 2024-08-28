using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{

    public class Student
    {
        public string name;
    }


    public class ValueTypeAndRefType
    {

        static void changeRefValue(Student student)
        {
            student.name = "Melinda";
        }

        static void changeValue(int val)
        {
            val = 200;
        }

        static void changeStringRef(string name)
        {
            name = "new name";
        }

        

        static void Main(string[] args)
        {
            /*
            int val = 100;

            Console.WriteLine(val);

            changeValue(val);

            Console.WriteLine(val);       
            */

            // Passing Ref Type Variable
            /*
            Student student = new Student();
            student.name = "Bill Gates";

            Console.WriteLine("Before calling the method the value is : "+student.name);

            changeRefValue(student);

            Console.WriteLine("After calling the method the value is : "+student.name);
            */

            // String is RefType, but it is Immutable
            string name = "old name";

            Console.WriteLine("before calling the mehtod: "+name);
            
            changeStringRef(name);

            Console.WriteLine("After calling the method: "+name);


         }

    }
}
