using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string read1 = System.IO.File.ReadAllText(@"C:\Users\ekaragoz\Desktop\read1.txt");
            string read2 = System.IO.File.ReadAllText(@"C:\Users\ekaragoz\Desktop\read2.txt");

            string write = read1 +"\t and \t"+ read2;

            System.IO.File.WriteAllText(@"C:\Users\ekaragoz\Desktop\write.txt",write);
            
            Console.ReadKey();
        }
    }
}
