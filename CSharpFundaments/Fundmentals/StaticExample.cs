using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{

    public class Watch
    {
        static Watch()
        {
            Console.WriteLine("static constructor is called once...");
        }

        public Watch()
        {
            Console.WriteLine("instance constructor is called once..");
        
        }

        public static void DisplayWatchTime()
        {
            Console.WriteLine("Date and Time Now: "+DateTime.Now);
        }

        public void DisplayWatchTimeInstance()
        {
            Console.WriteLine("Date and Time Now:  " + DateTime.Now.ToString());
                
        
        }     
           
    
    }

    public static class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
            Console.WriteLine(_resultStorage);
        }


            
    }

    class StopWatch
    {
        public static int NoofInstances = 0;

        // instance constructor
        public StopWatch() {
            StopWatch.NoofInstances++;
        
        }
    
    }




    public class StaticExample
    {
        static int counter = 0;
        string name = "Hello1234";

        static void Main(string[] args)
        {



            // Exmaple 1: 
            /*
            var result = Calculator.Sum(10, 25); // calling static method..
            Calculator.Store(result);


            var calcType = Calculator.Type; // accessing static variable
            Calculator.Type = "Scientific"; // assing value to static variable..
            */

            // Shared Static Fields
            /*
            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoofInstances); // 2

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoofInstances); // 4
            */


            //counter++;
            // Console.WriteLine(counter);

            //  Console.WriteLine(name);  non-static fields cannot be called from static fields..

            // display();

            // checkInput("ravi"); // An object reference to acces non-static method from static method..

            /*
            Watch.DisplayWatchTime();
            Watch.DisplayWatchTime();
            */

            Watch w1 = new Watch();
            Watch w2 = new Watch();
            w1.DisplayWatchTimeInstance();




            
         
        }

        static void display()
        {
            Console.WriteLine("Display Information...");
        }

        void checkInput(string input)
        {
            Console.WriteLine("input is good {0}",input);
        }

    }
}
