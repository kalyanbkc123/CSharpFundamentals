using CSharpFundaments.Fundmentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    class StringDataStore
    {

        private string[] strArr = new string[10]; 


        public string this[int index]
        {
            get 
            {
                if (index < 0 || index >= strArr.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                return strArr[index];
            
            
            }

            set
            { 
                if(index < 0 || index >= strArr.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                strArr [index] = value;
            
            }
        
        }
    }

    class DataStore<T> {

        private T[] store;

        public DataStore()
        { 
            store = new T[10];
        }

        public DataStore(int length)
        { 
            store = new T[length];
        }

        public T this[int index]
        {
            get {

                if (index < 0 || (index >= store.Length))
                { 
                    throw new IndexOutOfRangeException("Index is out of range..");
                }

                return store[index];
            }

            set {

                if (index < 0 || (index >= store.Length))
                {
                    throw new IndexOutOfRangeException("Index is out of range..");
                }

                store[index] = value;
            
            }
        }

        public int Length
        { 
            
            get { return store.Length; }
        }
    }

    // Overload Indexer

    class DataStorage
    {
        private string[] strArr =  new string[10];

        public string this[int index]
        {
            get { 
                
                if(index < 0 ||  index >= strArr.Length)
                { 
                    throw new IndexOutOfRangeException("Index out of range..");
                }

                return strArr[index];
            }

            set
            {
                if (index < 0 || (index >= strArr.Length))
                {

                    throw new IndexOutOfRangeException("Index out of range..");
                }

                strArr[index] = value;
            }
        
         }
            
        // string type indexer...
            public string this[string name]
            {

            get
            {
                        foreach (string str in strArr)
                        {
                            if (str.ToLower() == name.ToLower())
                            {
                                return str;
                            }
                        }
                return null;
            }
            
           
        
            }      
        
    }
    
    


    class Test
    {
        static void Main(string[] args)

        {
        /*
            StringDataStore s = new StringDataStore();

            s[0] = "one";
            s[1] = "two";
            s[2] = "three";
            s[3] = "four";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(s[i]);
            }

            DataStore<int> grades = new DataStore<int>();
            grades[0] = 100;
            grades[1] = 95;
            grades[2] = 80;
            grades[3] = 84;
            grades[4] = 76;
            grades[5] = 99;
            grades[6] = 54;
            grades[7] = 99;
            grades[8] = 43;
            grades[9] = 43;
           // grades[10] = 21;


            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }

            DataStore<string> store = new DataStore<string>();

            store[0] = "james";
            store[1] = "ravi";
            store[2] = "ravi";
            store[3] = "gamers";
            store[4] = "jahnavi";
            store[5] = "qill";

            Console.WriteLine();

            for(int i=0; i <store.Length; i++)
            {
                Console.WriteLine(store[i]);
            }

        */ 
        
        DataStorage store = new DataStorage();

        store[0] = "one";
        store[1] = "two";
        store[2] = "three";
        store[3] = "four";

        Console.WriteLine(store["one"]);
        Console.WriteLine(store["two"]);
        Console.WriteLine(store["three"]);
        Console.WriteLine(store["four"]);


        }
    }
}

