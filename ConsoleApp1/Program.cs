using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
            Console.WriteLine(class1.CheckVIN("WVGZZZCAZJC520863"));
            Console.WriteLine(class1.GetVINCountry("WVGZZZCAZJC520863"));
            Console.ReadKey();
        }
    }
}
