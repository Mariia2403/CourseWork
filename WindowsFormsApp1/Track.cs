﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Track : Transport
    {
        

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
