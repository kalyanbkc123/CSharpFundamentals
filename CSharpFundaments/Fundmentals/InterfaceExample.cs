using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    interface IFile
    {
        void read();
        void write(string file);
    }

    // Implicit Implemenation
    public class FileInfo : IFile
    {

        public void read()
        {
            Console.WriteLine("read the file..");
        }

        public void write(string file)
        {
            Console.WriteLine("writ the file....");
        }
    }

    // Explicit Implementation

    public class  FileInfo1 : IFile
    {
        void IFile.read()
        {
            Console.WriteLine("read method executed...");
        }

        void IFile.write(string file)
        {
            Console.WriteLine("write method executed....");
        }

        public void search(string pattern)
        {
            Console.WriteLine("searching...");
        }
    }



    public class InterfaceExample
    {

        static void Main(string[] args)
        {
            // Implicit Implementation...
            /*
            IFile file1 = new FileInfo();
            FileInfo file2 =  new FileInfo();

            file1.read();
            file1.write("content...");

            file2.read();
            file2.write("content..");
            */

            //Excplicit Implementation..
            IFile file1 = new FileInfo1();
            FileInfo1 file2 = new FileInfo1();


            file1.read();
            file1.write("Contnet..");

            // file2.read();  // compile time error
            // file2.write("content..."); // compile time error
            file2.search("content");

        
        }
    }
}
