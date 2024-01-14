using TezAPI.Domain.Entities;

namespace TezAPI.Application.Repositories;

public interface IAllergyReadRepository : IReadRepository<Domain.Entities.Allergy>
{
    Task<Allergy> GetRandomAllergyAsync();
}
