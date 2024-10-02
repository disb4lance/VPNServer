using Microsoft.AspNetCore.Mvc;


namespace VPN_Management.Presintation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VPNController : ControllerBase
    {
        [HttpGet(Name = "status")]
        public IActionResult GetStatus()
        {
            return Ok("VPN server is running.");
        }

        [HttpPost("connect")]
        public IActionResult ConnectVPN()
        {
            // Логика подключения VPN
            return Ok("VPN connection initiated.");
        }
    }
}
