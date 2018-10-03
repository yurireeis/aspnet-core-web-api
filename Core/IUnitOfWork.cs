using System;
using AspNetWebApi.Core.Repositories;

namespace AspNetWebApi.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        int Complete();
  }
}
