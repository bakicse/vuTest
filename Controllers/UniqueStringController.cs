using Microsoft.AspNetCore.Mvc;

namespace vuTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UniqueStringController : Controller
    {
        [HttpGet]
        public IActionResult GetUniqueString()
        {
            string uniqueString = Guid.NewGuid().ToString();
            return Ok(uniqueString);
        }
    }
}
