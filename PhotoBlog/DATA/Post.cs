namespace PhotoBlog.DATA
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public DateTime CreatedTime { get; set; }=DateTime.Now;

        public List<Tag> Tags { get; set; } = new();
    }
}
