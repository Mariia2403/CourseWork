using System;

namespace WindowsFormsApp1
{
    internal class Gazell : Transport
    {

        public override double CalculateTransportationCost()
        {
            double cost = 10;
            return weight * cost;
        }
        public override string GetTransportType()
        {
            return "Газель";
        }
    }
}
