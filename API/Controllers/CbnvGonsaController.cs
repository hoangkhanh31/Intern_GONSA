using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CbnvGonsaController : ControllerBase
    {
        private readonly GonsaContext _context;

        public CbnvGonsaController(GonsaContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.CbnvGonsas.ToList());
        }
    }
}
