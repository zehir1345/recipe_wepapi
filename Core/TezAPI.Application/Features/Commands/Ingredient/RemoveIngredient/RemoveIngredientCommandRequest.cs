using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Commands.Ingredient.RemoveIngredient
{
    public class RemoveIngredientCommandRequest : IRequest<RemoveIngredientCommandResponse>
    {
        public string Id { get; set; }
    }
}
