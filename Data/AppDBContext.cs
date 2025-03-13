using Microsoft.EntityFrameworkCore;

namespace azure_app_ym.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        { 
        
        }

        public DbSet<Person> Persons { get; set; }
    }
}
