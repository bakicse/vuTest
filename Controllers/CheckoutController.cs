using Microsoft.AspNetCore.Mvc;
using vuTest.Model;
using vuTest.Service;

namespace vuTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheckoutController(CheckoutService checkoutService) : Controller
    {
        [HttpPost("GenerateCheckoutUrl")]
        public async Task<IActionResult> GenerateCheckoutUrl([FromBody] SubscriptionModel subscription)
        {
            var checkoutUrl = await checkoutService.CreateCheckoutUrlAsync(subscription);
            return Ok(new { checkoutUrl });
        }
    }
}
