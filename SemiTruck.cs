namespace Inheretance
{
    class SemiTruck : Car, IAutomobile<Car>
    {
        public SemiTruck(string make, string model, string year) : base(make, model, year)
        {
            //notice how the 3 variables are differant than in sedan
            Wheels = 18;
            Gas = 100;
            MaxGas = 250;
        }
        //notice how the description is different than on sedan
        public override string Description()
        {
            return $"This Semitruck drives on {Wheels} wheels. was built by {Make}. The model is {Model}. and the year is {Year}, and has {Gas} gallons of diesel in the tank.";
        }
    }
}
