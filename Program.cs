using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretance
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan honda = new Sedan("Honda", "Accord", "2009");

            Console.WriteLine(honda.Description());
            Console.ReadKey();
        }
    }
}
