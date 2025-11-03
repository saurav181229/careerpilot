using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace CareerPilot.API.Controller
{
 
    
    [ApiController]
    [Route("api/[controller]")]
    public class PingController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get() => Ok("API is working ");
    }
    
}