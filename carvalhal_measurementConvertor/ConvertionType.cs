using System;
using System.Collections.Generic;
using System.Text;

namespace carvalhal_measurementConvertor
{
    class ConvertionType
    {
        public string Name { get; set; }
        public List<Unit> LstUnit { get; set; }

        public ConvertionType(string name, List<Unit> lstUnits)
        {
            this.Name = name;
            this.LstUnit = lstUnits;
        }

        /// <summary>
        /// Method which calculates the value of the convertion
        /// </summary>
        /// <param name="valueIn">input value</param>
        /// <param name="indexInt">puissance of input value</param>
        /// <param name="indexOut">puissance of output value</param>
        /// <returns></returns>
        public double Convertion(double valueIn, double indexInt, double indexOut)
        {
            double puissance = indexInt - indexOut;
            double valueOut = valueIn * Math.Pow(10, puissance);
            return valueOut;
        }
    }
}
