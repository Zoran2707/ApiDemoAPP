using ApiDemoWithTimCory.Data;
using ApiDemoWithTimCory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiDemoWithTimCory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly NorthwindDbContext _context;

        public RolesController(NorthwindDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Role> Get()
        {
         
            return _context.Role.ToList();
        }
    }
}
