using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using dotnet.api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id) 
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }
    }
}
