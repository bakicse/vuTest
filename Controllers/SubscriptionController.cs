﻿using Microsoft.AspNetCore.Mvc;
using vuTest.Model;

namespace vuTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionController : Controller
    {
        [HttpPost]
        public IActionResult GenerateRandomJson()
        {
            var subscription = new SubscriptionModel
            {
                Amount = "1",
                FirstPaymentIncludedInCycle = "True",
                ServiceId = "100001",
                Currency = "BDT",
                StartDate = DateTime.UtcNow.ToString("yyyy-MM-dd"),
                ExpiryDate = DateTime.UtcNow.AddDays(30).ToString("yyyy-MM-dd"),
                Frequency = "WEEKLY",
                SubscriptionType = "BASIC",
                MaxCapRequired = "False",
                MerchantShortCode = "01307153119",
                PayerType = "CUSTOMER",
                PaymentType = "FIXED",
                RedirectUrl = "https://bakitest.com",
                SubscriptionRequestId = Guid.NewGuid().ToString(),
                SubscriptionReference = "01712345678",
                CKey = "000001"
            };

            return Ok(subscription);
        }
    }
}