using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Track : Transport
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
            double cost = 50;
            return weight * cost;
        }

        public override string GetTransportType()
        {
            return "Фура";
        }
    }
}
