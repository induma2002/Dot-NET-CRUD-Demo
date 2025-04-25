using DemoApi.model;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.databases
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }  // Example entity

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(u => u.Id);
        }

    }
}
