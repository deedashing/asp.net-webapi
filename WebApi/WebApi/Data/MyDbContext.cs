using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options): base (options) { }

        public DbSet<Goods> Goods { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
