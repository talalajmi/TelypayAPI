using Microsoft.AspNetCore.Mvc;

namespace TelypayAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        [HttpPost]
        public IActionResult checkUser([FromQuery] string username, [FromQuery] string password)
        {
            if (username == "telypay" && password == "password123")
            {
                return StatusCode(200, "Success");
            }
            else if (username == "telypay" && password == "wrong-password")
            {
                return StatusCode(400, "Wrong Password");
            }
            else if (username == "error" && password == "error")
            {
                return StatusCode(500, "Error");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
