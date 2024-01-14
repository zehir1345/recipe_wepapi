using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities
{
    public class RecipeIngredient:BaseEntity
    {
        [ForeignKey(nameof(RecipeId))]
        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        [ForeignKey(nameof(IngredientId))]
        public Guid IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public string Amount { get; set; } // Malzemenin porsiyon miktarı
    }
}
