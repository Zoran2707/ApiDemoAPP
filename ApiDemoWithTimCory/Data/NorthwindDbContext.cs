using ApiDemoWithTimCory.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDemoWithTimCory.Data
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options) : base(options)
        {

        }

       

        public DbSet<Role> Role { get; set; }

        public DbSet<Region> Region { get; set; }

        public DbSet<Suplier> Suppliers { get; set; }
    }
}
