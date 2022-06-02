using api_net6.Models;
using Microsoft.EntityFrameworkCore;

namespace api_net6
{
  public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Localidad> Localidades { get; set; }
    }
}