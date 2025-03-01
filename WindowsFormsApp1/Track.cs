using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Track : Transport
    {
        public override double MaxWeight => 5000;

        public override double MaxVolume => 40;

        public override double CalculateTransportationCost()
        {
            double cost = 50;
            return Weight * cost * GetConditionCostFactor();
        }

        public override string GetTransportType()
        {
            return "Фура";
        }
    }
}
