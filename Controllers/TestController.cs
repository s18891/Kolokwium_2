using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium_2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_2.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private ITestDbService _service;

        public TestController(ITestDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult getTests(string name)
        {
            return Ok(_service.getTests());   
        }
    }
}