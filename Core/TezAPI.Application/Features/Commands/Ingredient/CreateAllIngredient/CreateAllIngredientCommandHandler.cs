using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Commands.Ingredient.CreateAllIngredient
{
    public class CreateAllIngredientCommandHandler : IRequestHandler<CreateAllIngredientCommandRequest, CreateAllIngredientCommandResponse>
    {
        readonly IIngredientWriteRepository _ingredientWriteRepository;

        public CreateAllIngredientCommandHandler(IIngredientWriteRepository ingredientWriteRepository)
        {
            _ingredientWriteRepository = ingredientWriteRepository;
        }

        public async Task<CreateAllIngredientCommandResponse> Handle(CreateAllIngredientCommandRequest request, CancellationToken cancellationToken)
        {
            List<Domain.Entities.Ingredient> ingredients = new List<Domain.Entities.Ingredient>();
            foreach (var item in request.Ingredients)
            {
                if (request.Ingredients != null)
                {
                    Domain.Entities.Ingredient ingredient = new()
                    {
                        Id = Guid.NewGuid(),
                        IngredientName = item.IngredientName,
                    };
                    ingredients.Add(ingredient);
                }
            }

            await _ingredientWriteRepository.AddRangeAsync(ingredients);
            int result = await _ingredientWriteRepository.SaveAsync();
            if (result > 0)
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
