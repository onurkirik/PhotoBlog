using PhotoBlog.Attributes;

namespace PhotoBlog.Areas.Admin.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [ValidImage(MaxFileSize = 2)]
        public IFormFile Photo { get; set; }
    }
}
