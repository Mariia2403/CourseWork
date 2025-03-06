using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Beads : Transport
    {
        public override double MaxWeight => 3000;
        public override double MaxVolume => 20;
        public Beads(string cargoType, double weight, double volume, string condition) : base(cargoType, weight, volume, condition)
        {

        }

        public override double CalculateTransportationCost()
        {
            double cost = 15;
            return Cargo.Weight * cost * GetConditionCostFactor();
        }

        public override string GetTransportType()
        {
            return "Beads";
        }
    }
}
