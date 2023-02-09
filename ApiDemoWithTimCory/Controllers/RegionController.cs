using ApiDemoWithTimCory.Data;
using ApiDemoWithTimCory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiDemoWithTimCory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly NorthwindDbContext _context;

        public RegionController(NorthwindDbContext context)
        {
            _context = context;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<Region> Get()
        {

            return _context.Region.ToList();
        }


        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {

            var region = _context.Region.FirstOrDefault(r => r.RegionID == id);


            return region == null ? NotFound() : Ok(region);

        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post(Region region)
        {
            _context.Region.Add(region).State = EntityState.Added;
            _context.SaveChanges();

        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, Region region)
        {
            if (id == region.RegionID)
            {
                _context.Entry(region).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var regionForDelete = _context.Region.FirstOrDefault(r => r.RegionID == id);
            if (regionForDelete == null) return NotFound();

            _context.Region.Remove(regionForDelete).State = EntityState.Deleted;
            _context.SaveChanges();
            return NoContent();



        }
    }
}
