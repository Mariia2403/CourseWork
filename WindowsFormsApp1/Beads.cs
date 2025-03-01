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

        public override double CalculateTransportationCost()
        {
            double cost = 15;
            return Weight * cost * GetConditionCostFactor();
        }

        public override string GetTransportType()
        {
            return "Бус";
        }
    }
}
