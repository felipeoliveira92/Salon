using Microsoft.EntityFrameworkCore;
using Salon.Model;

namespace Salon.Data
{
    public class Context : DbContext
    {
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        DbSet<Services> Services { get; set; }
        DbSet<User> Users { get; set; }
    }
}
