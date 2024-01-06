using FluentValidation;
using TezAPI.Application.ViewModel.Recipes;

namespace TezAPI.Application.Validators.Recipes
{
    public class CreateRecipeValidator : AbstractValidator<VM_Create_Recipe>
    {
        public CreateRecipeValidator() { 
          RuleFor(p=> p.CookingTime).NotEmpty();        
        }
    }
}
