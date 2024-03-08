using YouBlog.DAL.Interfaces;

namespace YouBlog.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public DateTime RegisteredAt { get; set; } = DateTime.Now;
        public string Description { get; set; }
    }
}
