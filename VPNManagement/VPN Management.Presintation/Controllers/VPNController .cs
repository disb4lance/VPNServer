using Microsoft.AspNetCore.Mvc;
using Service.Contract;


namespace VPN_Management.Presintation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VPNController : ControllerBase

    {
        private IVpnService _vpnService;

        public VPNController(IVpnService vpnService) {
            _vpnService = vpnService;
        }


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
