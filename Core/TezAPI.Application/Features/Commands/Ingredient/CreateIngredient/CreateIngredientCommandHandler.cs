using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Commands.Ingredient.CreateIngredient
{
    public class CreateIngredientCommandHandler : IRequestHandler<CreateIngredientCommandRequest, CreateIngredientCommandResponse>
    {
        readonly IIngredientWriteRepository _ingredientWriteRepository;

        public CreateIngredientCommandHandler(IIngredientWriteRepository ingredientWriteRepository)
        {
            _ingredientWriteRepository = ingredientWriteRepository;
        }

        public async Task<CreateIngredientCommandResponse> Handle(CreateIngredientCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Ingredient ingredient = new()
            {
                Id = Guid.NewGuid(),
                IngredientName = request.IngredientName,
            };
            await _ingredientWriteRepository.AddAsync(ingredient);
            int result = await _ingredientWriteRepository.SaveAsync();
            if (result >  0)
                return new()
                {
                    Succeded = true,
                    Message = "Malzeme başarıyla eklendi"
                };
            else
                throw new Exception("yükleme başarısız");
        }
    }
}
