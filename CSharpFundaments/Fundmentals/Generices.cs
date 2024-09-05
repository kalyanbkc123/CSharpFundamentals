using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    class DataStoring<T>        
    {
        public T Data {
            get;
            set;           
        }
    }

    //Generic class with Multiple type parameters...

    class KeyValuePair<TKey, TValue>
    { 
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    
    }

    class Main1
    {

        static void Main(string[] args)
        { 
            DataStoring<String>  store = new DataStoring<String>();

            store.Data = "Hello World";
            Console.WriteLine(store.Data);

            // store.Data = 123; // compile time error..

            DataStoring<int> store1 = new DataStoring<int>();
            store1.Data = 1234;
            Console.WriteLine(store1.Data);

            KeyValuePair<int, string> keyValuePair = new KeyValuePair<int, string>();

            keyValuePair.Key = 1234;
            keyValuePair.Value = "hello";

            Console.WriteLine(keyValuePair.Key+" "+keyValuePair.Value);

            KeyValuePair<string, string> keyValuePair1 = new KeyValuePair<string, string>();

            keyValuePair1.Key = "mr";
            keyValuePair1.Value = "ravi";

            Console.WriteLine(keyValuePair1.Key+" "+keyValuePair1.Value);

            //Generic Fields..

                      
            
        
        }

        class Datastore<T>
        {
            public T data;
        }

        class DataSTore<T>
        {
            public T[] data = new T[10];
        }

        class DATAStore<T>
        {
            private T[] _data = new T[10];

            public void AddOrUpdate(int index, T item)
            { 
            
                if(index >= 0 && index < 10)
                {
                    _data[index] = item;
                }
            }

            public T GetData(int index)
            { 
                if(index >= 0 && index < 10)
                {
                    return _data[index];
                }

                else
                {
                    return default(T);
                }
            
            }      
        
        
        }
    
    }


    class Main2
    { 
        static void Main(string[] args)
        {

           // DATAStore<string> cities = new DATAStore<string>();


                
                
                
                
        }
    
    
    }
}
