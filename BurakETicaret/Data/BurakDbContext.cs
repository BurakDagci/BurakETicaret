using BurakETicaret.Models;
using Microsoft.EntityFrameworkCore;

namespace BurakETicaret.Data
{
    public class BurakDbContext : DbContext
    {
        public BurakDbContext(DbContextOptions<BurakDbContext> options):base(options)
        {
        }
        public DbSet<Category>?Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Products>?  Products { get; set; }
        public DbSet<Slider>? Slider { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
    }
}
