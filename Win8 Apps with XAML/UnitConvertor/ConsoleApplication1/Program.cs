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
            Distance distance = new Distance();
            float res = distance.Conversion(1, "yard", "m");
            Console.WriteLine("{0}",res);
        }
    }
}
