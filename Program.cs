using System;

namespace Inheretance
{
    class Program
    {
        static void Main(string[] args)
        {
            //notice how you only need to define the make, model, and year when defining the classes
            Sedan honda = new Sedan("Honda", "Accord", "2009");
            SemiTruck truck = new SemiTruck("Ford", "IDK", "2018");

            //describes the class using the description function
            Console.WriteLine(honda.Description());
            honda.FillGas(10000);
            Console.WriteLine(honda.Description());
            Console.WriteLine(truck.Description());
            truck.EmptyGas(1000000);
            Console.WriteLine(truck.Description());
            Console.ReadKey();
        }
    }
}
