using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository

    {
        public UserReadRepository(TezAPIDbContext context) : base(context)
        {
        }
    }
}
