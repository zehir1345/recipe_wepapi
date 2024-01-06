using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Commands.Ingredient.CreateAllIngredient
{
    public class CreateAllIngredientCommandRequest : IRequest<CreateAllIngredientCommandResponse>
    {
        public List<Domain.Entities.Ingredient> Ingredients { get; set; } = new List<Domain.Entities.Ingredient>(); 
    }
}
