using Microsoft.EntityFrameworkCore;
using Server.Model;

namespace Server.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<Products> products { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
