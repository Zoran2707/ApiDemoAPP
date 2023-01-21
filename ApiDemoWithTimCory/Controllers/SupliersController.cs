using ApiDemoWithTimCory.Data;
using ApiDemoWithTimCory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDemoWithTimCory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupliersController : ControllerBase
    {
        private readonly SuplierDbContext _context;

        public SupliersController(SuplierDbContext context)
        {
            _context = context;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public  IEnumerable<Suplier> Get()
        {

            return _context.Suppliers.ToList();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            
            var suplier=_context.Suppliers.FirstOrDefault(s => s.SupplierID == id);
          

            return suplier==null ? NotFound() : Ok(suplier);
        
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post(Suplier suplier)
        {
            _context.Suppliers.Add(suplier).State = EntityState.Added;
            _context.SaveChanges();
            
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, Suplier suplier)
        {
            if(id == suplier.SupplierID)
            {
                _context.Entry(suplier).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id) 
        {
            var suplierForDelete=_context.Suppliers.FirstOrDefault(s => s.SupplierID == id);
            if (suplierForDelete == null) return NotFound();
      
                _context.Suppliers.Remove(suplierForDelete).State = EntityState.Deleted;
                _context.SaveChanges();
                return NoContent();
                
            
          
        }
    }
}
