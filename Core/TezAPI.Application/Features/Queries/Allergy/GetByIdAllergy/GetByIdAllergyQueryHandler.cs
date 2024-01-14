using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Queries.Allergy.GetByIdAllergy
{
    public class GetByIdAllergyQueryHandler : IRequestHandler<GetByIdAllergyQueryrequest, GetByIdAllergyQueryResponse>
    {
        readonly IAllergyReadRepository _allergyReadRepository;

        public GetByIdAllergyQueryHandler(IAllergyReadRepository allergyReadRepository)
        {
            _allergyReadRepository = allergyReadRepository;
        }

        public async Task<GetByIdAllergyQueryResponse> Handle(GetByIdAllergyQueryrequest request, CancellationToken cancellationToken)
        {
           var data = await _allergyReadRepository.GetByIdAsync(request.id);
            return new()
            {
                CreatedDate = data.CreatedDate,
                Id = data.Id,
                Name = data.Name,
            };
        }
    }
}
