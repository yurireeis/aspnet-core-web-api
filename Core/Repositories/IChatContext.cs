using Microsoft.EntityFrameworkCore;

namespace AspNetWebApi.Core.Repositories
{
    public interface IChatContext
    {
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
        void Dispose();
    }
}
