using System;

namespace WindowsFormsApp1
{
    internal class Gazell : Transport
    {
        public Gazell(string cargoType, double weight, double volume, string condition) : base(cargoType, weight, volume, condition)
        {

        }

        public override double MaxWeight => 1500;

        public override double MaxVolume => 12;
        public override double CalculateTransportationCost()
        {
            double cost = 10;
            return Cargo.Weight * cost * GetConditionCostFactor();
        }
        public override string GetTransportType()
        {
            return "Gazell";
        }
    }
}
