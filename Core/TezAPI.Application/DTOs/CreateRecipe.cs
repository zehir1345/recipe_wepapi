using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.DTOs
{
    public class CreateRecipe
    {
        public string RecipeName { get; set; }
        public string RecipeText { get; set; }
        public List<string> AmountofRecipe { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
