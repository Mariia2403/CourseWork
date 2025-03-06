using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Track : Transport
    {
        public override double MaxWeight => 5000;

        public override double MaxVolume => 40;

        public Track(string cargoType, double weight, double volume, string condition) : base(cargoType, weight, volume, condition)
        {

        }
        public override double CalculateTransportationCost()
        {
            double cost = 50;
            return Cargo.Weight * cost * GetConditionCostFactor();
        }

        public override string GetTransportType()
        {
            return "Track";
        }
    }
}
