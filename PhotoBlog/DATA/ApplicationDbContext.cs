using Microsoft.EntityFrameworkCore;

namespace PhotoBlog.DATA
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post()
                {
                    Id = 1,
                    Title="Mountain and Sea",
                    Description="jfdkasjfkajsdfkjasdkfa",
                    Photo="sample.jpg"
                });
        }
    }
}
