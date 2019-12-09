using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiksbankenAPI.Models
{
    public class ExchangeModel
    {
        public double AmountInSek { get; set; }

        public string Currency { get; set; }

        public DateTime Date { get; set; }
    }
}