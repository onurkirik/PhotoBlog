using Microsoft.EntityFrameworkCore;

namespace PhotoBlog.DATA
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }

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

            modelBuilder.Entity<Tag>().HasData(
                new Tag() { Id = 1, Name = "nature"},
                new Tag() { Id = 2, Name = "sea"},
                new Tag() { Id = 3, Name = "hiking"},
                new Tag() { Id = 4, Name = "sunset"},
                new Tag() { Id = 5, Name = "walk"},
                new Tag() { Id = 6, Name = "rain"}
                );
        }
    }
}
