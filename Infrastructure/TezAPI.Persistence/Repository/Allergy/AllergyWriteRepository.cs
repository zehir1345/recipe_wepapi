using TezAPI.Application.Repositories;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository
{
    public class AllergyWriteRepository : WriteRepository<Domain.Entities.Allergy>, IAllergyWriteRepository
    {
        public AllergyWriteRepository(TezAPIDbContext context) : base(context)
        {
        }
    }
}
