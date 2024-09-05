using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals;

public partial class Employee
{
    
        //constructor..
        public Employee(int EmpId, String EmpName)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
        }

        public void displayDetails()
        {
            Console.WriteLine(this.EmpId + " " + this.EmpName);
        }

    static void Main(string[] args)
    {
        var emp = new Employee(10,"Ravi");

        emp.displayDetails();

    }
    
}
