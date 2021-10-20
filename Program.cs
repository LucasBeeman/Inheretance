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
            SemiTruck truck = new SemiTruck("Make", "Model", "Year");

            Console.WriteLine(honda.Description());
            honda.FillGas(10000);
            Console.WriteLine(honda.Description());
            Console.ReadKey();
        }
    }
}
