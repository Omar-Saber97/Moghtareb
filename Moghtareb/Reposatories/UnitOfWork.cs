using Moghtareb.Interfaces;
using Moghtareb.Models;
using Moghtareb.Data;
using Moghtareb.Services;

namespace Moghtareb.Repository
{
    public class UnitOfWork : IUnityOfWork
    {
        private readonly ApplicationDbContext context;
       
        public UnitOfWork(ApplicationDbContext _context)
        {
            context = _context;
        }
        
        public int Complete()
        {
            return context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
