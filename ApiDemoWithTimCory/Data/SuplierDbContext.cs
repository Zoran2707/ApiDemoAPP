using ApiDemoWithTimCory.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDemoWithTimCory.Data
{
    public class SuplierDbContext : DbContext
    {
        public SuplierDbContext(DbContextOptions<SuplierDbContext> options) : base(options)
        {

        }

        public DbSet<Suplier> Suppliers { get; set; }
        
    }
}
