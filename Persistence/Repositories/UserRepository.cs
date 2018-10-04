using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AspNetWebApi.Core.Domain;
using AspNetWebApi.Core.Repositories;

namespace AspNetWebApi.Persistence.Repositories
{
  public class UserRepository : Repository<User>, IUserRepository
  {
      public UserRepository(IChatContext context) : base(context) { }
  }
}
