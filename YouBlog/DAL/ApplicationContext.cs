using Microsoft.EntityFrameworkCore;

namespace YouBlog.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        { }
    }
}
