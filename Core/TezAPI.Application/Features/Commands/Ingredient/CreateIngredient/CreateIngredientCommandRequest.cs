using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Commands.Ingredient.CreateIngredient
{
    public class CreateIngredientCommandRequest : IRequest<CreateIngredientCommandResponse>
    {
       public string IngredientName { get; set; }
    }
}
