using RiksbankenAPI.Models;
using RiksbankenService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RiksbankenAPI.Controllers
{
    public class ExchangeController : ApiController
    {
        [HttpPost]
        public double? GetExchangerate([FromBody]ExchangeModel model)
        {
            var service = new Service();

            return service.GetExchangerate(model.AmountInSek, model.Currency, model.Date);
        }
    }
}
