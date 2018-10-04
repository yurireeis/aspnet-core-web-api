using AspNetWebApi.Core;
using AspNetWebApi.Core.Repositories;

namespace AspNetWebApi.Persistence
{
    public class UnityOfWork : IUnitOfWork
    {
        public readonly IChatContext _context;

        public IUserRepository Users { get; private set; }

        public UnityOfWork(IChatContext context, IUserRepository user)
        {
            _context = context;
            Users = user;
        }

        public int Complete() => _context.SaveChanges();
        
        public void Dispose() => _context.Dispose();
    }
}
