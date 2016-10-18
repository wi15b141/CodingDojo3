using CodingDojo4DataLib.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3.Converters
{
    
    class PriceConverter
    {
        public double pricec;

        public double CalculateSalesPriceFromEuro(Currencies currency, double priceb)
        {
            this.pricec = CurrencyConverter.ConvertFromEuroTo(currency,priceb);
            return this.pricec;
        }
    }
}
