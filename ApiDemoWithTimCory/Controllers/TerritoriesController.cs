using ApiDemoWithTimCory.Data;
using ApiDemoWithTimCory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiDemoWithTimCory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoriesController : ControllerBase
    {
        private readonly NorthwindDbContext _context;

        public TerritoriesController(NorthwindDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Territorie> Get()
        {

            return _context.Territories.ToList();
        }


        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(string id)
        {

            var territorie = _context.Territories.FirstOrDefault(t => t.TerritoryID == id);


            return territorie == null ? NotFound() : Ok(territorie);

        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post(Territorie territorie)
        {
            _context.Territories.Add(territorie).State = EntityState.Added;
            _context.SaveChanges();

        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(string id, Territorie territorie)
        {
            if (id == territorie.TerritoryID)
            {
                _context.Entry(territorie).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(string id)
        {
            var territorieForDelete = _context.Territories.FirstOrDefault(t => t.TerritoryID == id);
            if (territorieForDelete == null) return NotFound();

            _context.Territories.Remove(territorieForDelete).State = EntityState.Deleted;
            _context.SaveChanges();
            return NoContent();



        }
    }
}
