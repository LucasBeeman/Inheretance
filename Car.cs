using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretance
{
    abstract class Car : IAutomobile<Car>
    {
        public string Make { get; protected set; }
        public string Model { get; protected set; }
        public string Year { get; protected set; }
        public double Gas { get;  protected set; }
        public double MaxGas { get; protected set; }
        public int Wheels { get; protected set; }

        public bool Equals(Car car)
        {
            return (this.Make, this.Model, this.Year, this.Gas, this.MaxGas) ==
                (car.Make, car.Model, car.Year, car.Gas, car.MaxGas);
        }

        public Car(string make, string model, string year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public void FillGas(double amount)
        {
            Gas += amount;
            if (Gas > MaxGas)
            {
                Gas = MaxGas;
            }
            else if (Gas < 0)
            {
                Gas = 0;
            }
        }

        public abstract string Description();
    }
}
