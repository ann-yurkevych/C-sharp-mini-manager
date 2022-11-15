using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    internal class Converter
    {
        decimal dollar;
        decimal euro;

        public Converter(decimal dollar, decimal euro)
        {
            this.dollar = dollar;
            this.euro = euro;
        }
        public decimal ConvertGrnToDollar(decimal grn)
        {
            return decimal.Multiply(grn, dollar);
        }
        public decimal ConvertGrnToEuro(decimal grn)
        {
            return decimal.Multiply(grn, euro);
        }
        public decimal ConvertDollarToGrn(decimal dollars)
        {
            return decimal.Divide(dollars, dollar);
        }
        public decimal ConvertEuroToGrn(decimal euros)
        {
            return decimal.Divide(euros, euro);
        }

    }
}
