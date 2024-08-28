using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    public class AnonymousType
    {
        static void Main(string[] args)
        {
            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };

            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);


        }
    }
}
