using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Commands.Ingredient.RemoveIngredient
{
    public class RemoveIngredientCommandResponse
    {
        public bool Succeded { get; set; }
        public string Message { get; set; }
    }
}
