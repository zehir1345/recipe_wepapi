using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Commands.Ingredient.RemoveIngredient
{
    public class RemoveIngredientCommandHandler : IRequestHandler<RemoveIngredientCommandRequest, RemoveIngredientCommandResponse>
    {
        readonly IIngredientWriteRepository _ingredientWriteRepository;
        readonly IIngredientReadRepository _ingredientReadRepository;
        public RemoveIngredientCommandHandler(IIngredientWriteRepository ingredientWriteRepository, IIngredientReadRepository ingredientReadRepository)
        {
            _ingredientWriteRepository = ingredientWriteRepository;
            _ingredientReadRepository = ingredientReadRepository;
        }

        public async Task<RemoveIngredientCommandResponse> Handle(RemoveIngredientCommandRequest request, CancellationToken cancellationToken)
        {
            var i = await _ingredientReadRepository.GetByIdAsync(request.Id);
            bool isOk = _ingredientWriteRepository.Remove(i);
            if (isOk) await _ingredientWriteRepository.SaveAsync();
            if (isOk)
                return new()
                {
                    Succeded = true,
                    Message = "Malzeme başarıyla silindi"
                };
            else
                throw new Exception("Silme işlemi başarısız");
        }
    }
}
