using Microsoft.EntityFrameworkCore;

namespace Deployment.Controllers
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
