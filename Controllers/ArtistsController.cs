using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium_2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_2.Controllers
{
    [Route("api/artists/{id}")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly ITestDbService _service;

        public ArtistsController(ITestDbService service)
        {
            _service = service;
        }
        public IActionResult GetArtists(int id) {
             
            
            
            return Ok(_service.GetArtist(id));
        }
    }
}
