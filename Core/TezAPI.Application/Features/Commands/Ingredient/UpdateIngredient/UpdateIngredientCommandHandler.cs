using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Commands.Ingredient.UpdateIngredient
{
    public class UpdateIngredientCommandHandler : IRequestHandler<UpdateIngredientCommandRequest, UpdateIngredientCommandResponse>
    {
        readonly IIngredientWriteRepository _ingredientWriteRepository;
        readonly IIngredientReadRepository _ingredientReadRepository;

        public UpdateIngredientCommandHandler(IIngredientWriteRepository ingredientWriteRepository, IIngredientReadRepository ingredientReadRepository)
        {
            _ingredientWriteRepository = ingredientWriteRepository;
            _ingredientReadRepository = ingredientReadRepository;
        }

        public async Task<UpdateIngredientCommandResponse> Handle(UpdateIngredientCommandRequest request, CancellationToken cancellationToken)
        {
            var s = await _ingredientReadRepository.GetSingleAsync(i => i.Id == request.Id);
          
            s.CreatedDate =    request.CreatedDate;
            s.IngredientName = request.IngredientName;
          
            bool isOk = _ingredientWriteRepository.Update(s);
            if (isOk) await _ingredientWriteRepository.SaveAsync();
            if (isOk)
                return new()
                {
                    Succeded = true,
                    Message = "Malzeme başarıyla güncellendi"
                };
            else
                throw new Exception("Güncelleme işlemi başarısız");
        }
    }
}
