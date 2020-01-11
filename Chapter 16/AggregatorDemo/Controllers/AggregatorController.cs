using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AggregatorDemo.Services;

namespace AggregatorDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AggregatorController : ControllerBase
    {
        private IDependentDataService _dependentService;

        public AggregatorController(IDependentDataService depSvc)
        {
            _dependentService = depSvc;
        }

        [HttpGet("data")]
        public async Task<ActionResult<string>> Get()
        {
            return await _dependentService.GetDataResponse();
        }
    }
}