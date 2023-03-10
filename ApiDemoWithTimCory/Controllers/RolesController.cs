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


        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {

            var role = _context.Role.FirstOrDefault(r => r.Id == id);


            return role == null ? NotFound() : Ok(role);

        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post(Role role)
        {
            _context.Role.Add(role).State = EntityState.Added;
            _context.SaveChanges();

        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, Role role)
        {
            if (id == role.Id)
            {
                _context.Entry(role).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var roleForDelete = _context.Role.FirstOrDefault(r => r.Id == id);
            if (roleForDelete == null) return NotFound();

            _context.Role.Remove(roleForDelete).State = EntityState.Deleted;
            _context.SaveChanges();
            return NoContent();



        }
    }
}
