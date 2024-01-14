using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Queries.Allergy.GetByIdAllergy
{
    public class GetByIdAllergyQueryrequest : IRequest<GetByIdAllergyQueryResponse>
    {
        public string id { get; set; }
    }
}
