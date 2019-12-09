using RiksbankenService.RiksbankenServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiksbankenService
{
    public class Service
    {
        public double? GetExchangerate(double amountInSek, string currency, DateTime date)
        {
            
            var client = new SweaWebServicePortTypeClient();
            
            var rate = client.getMonthlyAverageExchangeRates(date.Year, date.Month, LanguageType.en);

            var exchangeRate = rate.groups.First().series.Where(v => v.seriesname == currency).First().resultrows.First().average;
            var amountInCurrency = amountInSek / exchangeRate;

            return amountInCurrency;
           
        }
    }
}
