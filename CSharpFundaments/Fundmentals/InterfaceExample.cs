using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundaments.Fundmentals
{
    interface IFileDefaultEx
    {
        void read();
        void write(string content);

        public void info()
        {
            Console.WriteLine("default method in the interface that has to be implemented.....");
        }
    }

    class FileForamt2 : IFileDefaultEx
    {
        void IFileDefaultEx.read()
        {
            Console.WriteLine("read method is executed..");
        }

        void IFileDefaultEx.write(string content) {

            Console.WriteLine("write method is executed..");
            
        }

        public void search()
        {
            Console.WriteLine("hai how r u doing...");
        }
    }




    interface IFile
    {
        void read();
        void write(string file);
    }

    interface IBinaryFile {

        void OpenBinaryFile();
        void ReadFile();
    
    }

    public class FileForamt : IFile, IBinaryFile
    {
        void IFile.read()
        {
            Console.WriteLine("read file() in IFile");
        }

        void IFile.write(string file)
        {
            Console.WriteLine("write file in IFile");
        }

        void IBinaryFile.ReadFile() {

            Console.WriteLine("read file in IBinaryFile");
        
        }

        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("open binary file in IBinary file...");

        }

        public void Search()
        {
            Console.WriteLine("search operation has to be done..");
        }
    
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
            /*
            IFile file1 = new FileInfo1();
            FileInfo1 file2 = new FileInfo1();


            file1.read();
            file1.write("Contnet..");

            // file2.read();  // compile time error
            // file2.write("content..."); // compile time error
            file2.search("content");

            */
            /*
            IFile file1 = new FileForamt();
            IBinaryFile file2 = new FileForamt();
            FileForamt file3 = new FileForamt();

            file1.read();
            file1.write("content");
            //file1.OpenbinaryFile(); // gives compile time error..
            //file1.ReadFile(); // gives compile time error..

            file2.OpenBinaryFile(); 
            file2.ReadFile();
            //file2.read(); // gives compile time error
            //file2.write("content"); // gives compile time error

            file3.Search();
            // if we call remaining method we will get runtime exception..
            */

            IFileDefaultEx file1 = new FileForamt2();
            FileForamt2 file2 = new FileForamt2();

            file1.read();
            file1.write("content");
            file1.info();

            //file2.read(); // compiler time error
           // file2.write("content"); // compile time error
           // file2.info(); // compiler time error    
            file2.search();





        }
    }
}
