using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Beads : Transport
    {
        
        public override double CalculateTransportationCost()
        {
            double cost = 15;
            return weight * cost;
        }

        public override string GetTransportType()
        {
            return "Бус";
        }
    }
}
