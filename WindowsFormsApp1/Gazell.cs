using System;

namespace WindowsFormsApp1
{
    internal class Gazell : Transport
    {
        public override double MaxWeight => 1500;

        public override double MaxVolume => 12;
        public override double CalculateTransportationCost()
        {
            double cost = 10;
            return Weight * cost * GetConditionCostFactor();
        }
        public override string GetTransportType()
        {
            return "Газель";
        }
    }
}
