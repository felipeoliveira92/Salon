using Microsoft.EntityFrameworkCore;
using Salon.Model.Models;

namespace Salon.Infra.Context
{
    public class SalonContext : DbContext
    {
        public SalonContext()
        {

        }
        public SalonContext(DbContextOptions<SalonContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var stringConnection = "Integrated Security=SSPI;Persist Security Info=False;" +
                "User ID=sa;Initial Catalog=dbSalon;Data Source=DESKTOP-FELIPE";

            optionsBuilder.UseSqlServer(stringConnection);
        }
    }
}