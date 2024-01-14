using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Queries.Allergy.GetAllAllergy
{
    public class GetAllAllergyQueryHandler : IRequestHandler<GetAllAllergyQueryRequesst, GetAllAllergyQueryResponse>
    {
        readonly IAllergyReadRepository _allergyReadRepository;

        public GetAllAllergyQueryHandler(IAllergyReadRepository allergyReadRepository)
        {
            _allergyReadRepository = allergyReadRepository;
        }

        public async Task<GetAllAllergyQueryResponse> Handle(GetAllAllergyQueryRequesst request, CancellationToken cancellationToken)
        {
            var data= _allergyReadRepository.GetAll();
            return new()
            {
                AllergyList = data.ToList(),
                TotalCategoryCount = data.Count()
            };
        }
    }
}
