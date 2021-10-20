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
            Wheels = 4;
            Gas = 10;
            MaxGas = 18.5;
        }

        public override string Description()
        {
            return $"This Sedan drives on {Wheels} wheels. was built by {Make}. The model is {Model}. and the year is {Year}, and has {Gas} gallson of gas in the tank.";
        }
    }
}
