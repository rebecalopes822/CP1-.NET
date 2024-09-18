using CP1_.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace CP1_.NET.Data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }

        public DbSet<user> Users { get; set; }
    }
}
