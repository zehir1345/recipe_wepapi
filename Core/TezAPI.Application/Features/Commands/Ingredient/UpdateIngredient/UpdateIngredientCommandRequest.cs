using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Commands.Ingredient.UpdateIngredient
{
    public class UpdateIngredientCommandRequest : IRequest<UpdateIngredientCommandResponse>
    {
        public Guid Id { get; set; }
        public string IngredientName { get; set; }S
        public DateTime CreatedDate { get; set; }
    }
}
