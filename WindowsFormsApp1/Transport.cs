using System;

namespace WindowsFormsApp1
{
    public abstract class Transport
    {

        protected double weight { get; set; }
        protected double volume { get; set; }
        public string SpecialCondition { get; set; } = "No necessary";
        public virtual double Weight
        {
            get => weight;
            set => weight = (value < 0) ? throw new ArgumentException("The weight cannot be less than zero.") : value;
        }

        public virtual double Volume
        {
            get => volume;
            set => volume = (value < 0) ? throw new ArgumentException("The weight cannot be less than zero.") : value;
        }

        public virtual double GetConditionCostFactor()
        {
            double factor;
            switch (SpecialCondition)
            {
                case "Cooling":
                    factor = 1.5;
                    break;
                case "Amortization":
                    factor = 1.2;
                    break;
                case "Sealed":
                    factor = 1.3;
                    break;
                case "No necessary":
                    factor = 1.0;
                    break;
                default:
                    factor = 1.0;
                    break;
            }
            return factor;

        }

        public abstract double CalculateTransportationCost();//
        public abstract string GetTransportType();

    }
}
