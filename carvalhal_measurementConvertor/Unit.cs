using System;
using System.Collections.Generic;
using System.Text;

namespace carvalhal_measurementConvertor
{
    class Unit
    {
        public string UnitName { get; set; }
        public double Puissance { get; set; }

        public Unit(string unitName, double puissance)
        {
            this.UnitName = unitName;
            this.Puissance = puissance;
        }
    }
}
