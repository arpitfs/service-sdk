using Microsoft.AspNetCore.Mvc;

namespace ServiceKit.Api.Controller
{
    public class ServiceController : ControllerBase
    {
        [Route("api/Service")]
        [HttpGet]
        public IActionResult GetService()
        {
            var service = new Service { ServiceId = 1, ServiceName = "ServiceName" };
            return Ok(service);
        }
    }
}
