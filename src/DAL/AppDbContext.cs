using Microsoft.EntityFrameworkCore;
using src.Entities;

namespace src.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}