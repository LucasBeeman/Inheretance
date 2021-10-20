using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretance
{
    class SemiTruck : Car, IAutomobile<Car>
    {
        public SemiTruck(string make, string model, string year) : base(make, model, year)
        {
            Wheels = 18;
            Gas = 100;
            MaxGas = 200;
        }

        public override string Description()
        {
            return $"This semi truck drives on {Wheels} wheels. was built by {Make}. The model is {Model}. and the year is {Year}, and has {Gas} gallons of diesel in the tank.";
        }
    }
}
