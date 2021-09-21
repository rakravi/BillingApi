using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using BusinessLayer.BusinessModel;
using System.Collections.Generic;
using System;

namespace BillingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
        private IBillingBlContract _billingBusiness;
        public BillingController(IBillingBlContract billingBl)
        {
            _billingBusiness = billingBl;
        }

        [Route("Bill")]
        [HttpPost]
        public IActionResult CalculateFinalCheck([FromBody] List<PurchasedItems> purchasedItems)
        {
            ObjectResult response;
            try
            {
                var billDetails = _billingBusiness.CalculateFinalCheck(purchasedItems);
                response = StatusCode(StatusCodes.Status200OK, billDetails);
            }
            catch (Exception ex)
            {
                response = StatusCode(StatusCodes.Status400BadRequest, "Bad Agency data");
            }

            return response;
        }
    }
}
