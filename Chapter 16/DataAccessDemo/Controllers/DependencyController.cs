using System;
using System.Threading;
using DataAccessDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DataAccessDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependencyController : ControllerBase
    {
        [HttpGet("new-data")]
        public ActionResult<string> GetDependentValue()
        {
            Thread.Sleep(Latency.GetLatency());
            return $"requested data: {new Random().Next() }";
        }

        [HttpGet("reset")]
        public ActionResult<string> Reset()
        {
            Latency.ResetLatency();
            return "success";
        }
    }
}