using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Transport
    {
        
        public abstract double Weight { get; set; }
        public abstract double CalculateTransportationCost();//
        public abstract string GetTransportType();

    }
}
