using Microsoft.EntityFrameworkCore;

namespace LinqWork.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Enrolled> Enrolled { get; set; }
    }
}
