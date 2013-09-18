using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            float res = temperature.Conversion(1, "fahrenheit", "celsius");
            Console.WriteLine("{0}",res);
        }
    }
}
