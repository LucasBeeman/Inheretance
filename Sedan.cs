using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretance
{
    class Sedan : Car
    {
        public Sedan(string make, string model, string year) : base(make, model, year)
        {
            Wheels = 4;
            Gas = 50;
            MaxGas = 100;
        }

        public override string Description()
        {
            return $"This Sedan drives on {Wheels} wheels. was built by {Make}. The model is {Model}. and the year is {Year}";
        }
    }
}
