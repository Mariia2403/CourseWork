using System;

namespace WindowsFormsApp1
{
    internal class Gazell : Transport
    {
        private double weight;
        public override double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Вага не може бути меншою за нуль.");

                }
                weight = value;
            }
        }

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
