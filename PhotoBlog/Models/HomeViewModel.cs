using PhotoBlog.DATA;

namespace PhotoBlog.Models
{
    public class HomeViewModel
    {
        public List<Post> Posts { get; set; } = new();
        public string? Search { get; set; }
    }
}
