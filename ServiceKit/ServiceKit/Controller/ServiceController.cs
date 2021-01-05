using Microsoft.AspNetCore.Mvc;
using ServiceKit.Contracts;

namespace ServiceKit.Api.Controller
{
    public class ServiceController : ControllerBase
    {
        [Route("api/Service")]
        [HttpGet]
        public IActionResult GetService()
        {
            var service = new Service { ServiceId = 1, ServiceName = "ServiceName" };
            var serviceResponse = new ServiceResponse() { ServiceId = service.ServiceId, ServiceName = service.ServiceName };
            return Ok(serviceResponse);
        }
    }
}
