using MediatR;
namespace TezAPI.Application.Features.Queries.Category.GetByIdCategory
{
    public class GetCategoryByIdQueryRequest : IRequest<GetCategoryByIdQueryResponse>
    {
        public string Id { get; set; }
    }
}
