using Health.Server.Data;
using Health.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Health.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {

        private readonly AppDbContext Context;  

        public StatusController(AppDbContext context)
        {
            this.Context = context; 
        }


       [HttpPost] 

       public async Task<IActionResult> CreateHealthStatus([FromBody] Status status)
        {
            await this.Context.Statuses.AddAsync(status);
            await this.Context.SaveChangesAsync();

            return Ok(""); 
        }
    }
}
