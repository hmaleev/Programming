using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Speed speed = new Speed();
            float res = speed.Conversion(1, "km/h", "mi/h");
            Console.WriteLine("{0}",res);
        }
    }
}
