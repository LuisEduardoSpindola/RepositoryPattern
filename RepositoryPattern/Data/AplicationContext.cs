using Microsoft.EntityFrameworkCore;
using MicroSource.Api.Models;

namespace RepositoryPattern.Data
{
    public class AplicationContext : DbContext
    {
        public AplicationContext() { }

        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
