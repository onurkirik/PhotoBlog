using System.ComponentModel.DataAnnotations;

namespace PhotoBlog.DATA
{
    public class Tag
    {
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        public List<Post> Posts { get; set; } = new();

    }
}
