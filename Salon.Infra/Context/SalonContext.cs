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
        public DbSet<WorkTask> Tasks { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var stringConnection = "Integrated Security=SSPI;Persist Security Info=False;" +
            //    "User ID=sa;Initial Catalog=dbSalon;Data Source=DESKTOP-FELIPE";

            var stringConnection = @"Data Source=192.168.1.112;Initial Catalog=dbSalon; User Id=sa;Password=Alarmaq2014@";

            optionsBuilder.UseSqlServer(stringConnection);
        }
    }
}