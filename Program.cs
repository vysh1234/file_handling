using System;
using System.IO;

namespace file_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's see file handling:");

            FileStream fs = new FileStream("C:\\Users\\vaishnavi.vinjam\\source\\repos\\file_handling\\file.txt",FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("let's read and display from file");

            string str = sr.ReadLine();
            while(str!=null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
        }
    }
}
