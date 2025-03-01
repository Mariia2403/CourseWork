using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public abstract class Transport
    {
        public abstract double MaxWeight { get; }
        public abstract double MaxVolume { get; }
        protected double weight { get; set; }
        protected double volume { get; set; }
        public string SpecialCondition { get; set; } = "No necessary";

        public bool ex = false;
        public virtual double Weight
        {
            get => weight;
            set
            {
                if (value < 0)
                {
                    
                    throw new ArgumentException("The value cannot be less than zero.");

                }
                if (value > MaxWeight)
                {
                    ex = true;
                    MessageBox.Show($"The weight cannot exceed the maximum limit of {MaxWeight} kg.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    //  throw new ArgumentException($"The weight cannot exceed the maximum limit of {MaxWeight} kg.");

                }

                weight = value;

            }
        }

        public virtual double Volume
        {
            get => volume;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value cannot be less than zero.");

                }
                if (value > MaxVolume)
                {
                    ex = true;
                    MessageBox.Show($"The volume cannot exceed the maximum limit of {MaxVolume} m³.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    // throw new ArgumentException($"The volume cannot exceed the maximum limit of {MaxVolume} m³.");

                }
                volume = value;
            }
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
