using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretance
{
    public class Car : IAutomobile<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public bool Equals(Car car)
        {
            return (this.Make, this.Model, this.Year) ==
                (car.Make, car.Model, car.Year);
        }
    }
}
