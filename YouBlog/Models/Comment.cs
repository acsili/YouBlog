using YouBlog.DAL.Interfaces;

namespace YouBlog.Models
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int AuthorId { get; set; }
    }
}
