namespace Inheretance
{
    class Sedan : Car, IAutomobile<Car>
    {
        //we use base to define derive the variables from the super class.
        public Sedan(string make, string model, string year) : base(make, model, year)
        {
            //notice how the make, model, and year aren't defined here, we'll define it when we define the class
            Wheels = 4;
            Gas = 10;
            MaxGas = 18.5;
        }
        //we use override for an abstract functions
        public override string Description()
        {
            return $"This Sedan drives on {Wheels} wheels. was built by {Make}. The model is {Model}. and the year is {Year}, and has {Gas} gallons of gas in the tank.";
        }
    }
}
