using Microsoft.EntityFrameworkCore;
using YouBlog.DAL.Interfaces;
using YouBlog.Models;

namespace YouBlog.DAL.Repository
{
    public class UserRepository : IRepository<User>, IDisposable
    {
        private ApplicationContext _context;
        public UserRepository(ApplicationContext context) 
        {
            _context = context;
        }
        public async Task Create(User item)
        {
            await _context.Users.AddAsync(item);
        }

        public async Task<bool> Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is { })
            {
                _context.Users.Remove(user);
                return true;
            }

            return false;
        }


        public async Task<User> Get(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(User item)
        {
            _context.Users.Update(item);
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
