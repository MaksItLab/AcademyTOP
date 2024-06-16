using AcademyTOP.DataAccessLayer.Configurations;
using AcademyTOP.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace AcademyTOP.DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Request> Requests { get; set; }
        public DbSet<Admin> Admins { get; set; }


        public ApplicationDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RQ4I36L\\SQLEXPRESS;Database=AcademyTop;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RequestConfiguration());
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
        }
    }
}
