using MediatR;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Commands.Category.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
    {
        readonly ICategoryWriteRepository _categoryWriteRepository;

        public CreateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryWriteRepository = categoryWriteRepository;
        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            TezAPI.Domain.Entities.Category category = new()
            {
                Id = Guid.NewGuid(),
                CategoryName = request.CategoryName,
            };
           await _categoryWriteRepository.AddAsync(category);
            int result = await _categoryWriteRepository.SaveAsync();
            if (result > 0)
                return new()
                {
                    Succeded = true,
                    Message = "Catgegori başarıyla eklendi"
                };
            else
                throw new Exception("yükleme başarısısz");

        }
    }
}
