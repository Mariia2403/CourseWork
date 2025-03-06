using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public abstract class Transport
    {
        public abstract double MaxWeight { get; }
        public abstract double MaxVolume { get; }
        
        public string SpecialCondition { get; set; } = "No necessary";

        public Cargo Cargo { get; set; }

        public Transport(string cargoType, double weight, double volume, string condition)
        {
            Cargo = new Cargo(cargoType, weight, volume, condition, MaxWeight, MaxVolume);
        }

        public  double GetConditionCostFactor()
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
