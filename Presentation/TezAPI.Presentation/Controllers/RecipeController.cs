using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using TezAPI.Application.Abstractions.Storage;
using TezAPI.Application.DTOs;
using TezAPI.Application.Features.Queries.Recipe.GetAllReciipe;
using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities;

namespace TezAPI.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecipeController : ControllerBase
{
    readonly private IRecipeWriteRepository _recipeWriteRepository;
    readonly private IRecipeReadRepository _recipeReadRepository;
    readonly private IAllergyReadRepository _allergyReadRepository;
    readonly private IIngredientReadRepository _ingredientReadRepository;
    readonly private ICategoryReadRepository _categoryReadRepository;
    readonly IStorageService _storageService;
    private readonly IRecipeImageFileWriteRepository _fileWriteRepository;

    readonly IMediator _mediator;
    public RecipeController(IRecipeWriteRepository recipeWriteRepository, IAllergyReadRepository allergyReadRepository, IIngredientReadRepository ingredientReadRepository, ICategoryReadRepository categoryReadRepository, IMediator mediator,
        IStorageService storageService
        ,IRecipeImageFileWriteRepository recipeImageFileWriteRepository, IRecipeReadRepository recipeReadRepository)
    {
        _recipeWriteRepository = recipeWriteRepository;
        _allergyReadRepository = allergyReadRepository;
        _ingredientReadRepository = ingredientReadRepository;
        _categoryReadRepository = categoryReadRepository;
        _storageService = storageService;
        _mediator = mediator;
        _recipeReadRepository = recipeReadRepository;
        _fileWriteRepository = recipeImageFileWriteRepository;
    }
   
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery]GetAllRecipeQueryRequest getAllRecipeQueryReuest) 
    {  
       GetAllRecipeQueryResponse response = await _mediator.Send(getAllRecipeQueryReuest);
       return Ok(response);
    }
    [HttpPost]
    public async Task<IActionResult> Post()
    {
        //var c = new Category()
        //{
        //    CategoryName = "adw",
        //    CreatedDate = DateTime.UtcNow,
        //    Id = Guid.NewGuid()

        //};
        //var i = new Ingredient { Id = Guid.NewGuid(),
        //    CreatedDate = DateTime.UtcNow,
        //    IngredientName = "vgdg",
       
        //};
        //var recipe = new Recipe()
        //{
        //    CreatedDate = DateTime.UtcNow,
        //    Id = Guid.NewGuid(),
        //    CookingTime = 3,
        //    PreparationTime = 3,
        //    RecipeText = "sfe",

        //};
        //recipe.Ingredients.Add(i);
        //recipe.Categories.Add(c);
        //await _recipeWriteRepository.AddAsync(recipe);
        //await _recipeWriteRepository.SaveAsync();
        ////test için
        //if(ModelState.IsValid)
        //{
            
        //}

        return Ok();
    }
    [HttpPost ("[action]")]
    public async Task<IActionResult> CreateAllRecipe(List<CreateRecipe> models)
    {
        var allIngredients = _ingredientReadRepository.GetAll();
        if (models != null)
        {
            List<Recipe> recipes = new List<Recipe>();
         
            foreach (var model in models)
            {
                Recipe recipe = new Recipe();
                Allergy allergy = await _allergyReadRepository.GetRandomAllergyAsync();
                List<Category> categories = new List<Category>();
                List<Ingredient> ingredients = new List<Ingredient>();
                List<RecipeIngredient> recipeIngredients = new List<RecipeIngredient>();
                recipe.Id = Guid.NewGuid();
                recipe.AllergyId = allergy.Id;
                recipe.RecipeName = model.RecipeName;
                recipe.RecipeText = model.RecipeText;
                recipe.Allergy = allergy;
                recipe.CookingTime = 10;
                recipe.CookingTime = 5;
               
                if (model.Categories != null)
                {
                    foreach (string category in model.Categories)
                    {
                        Category category1 = new Category();

                        category1 = await _categoryReadRepository.GetSingleAsync(i => i.CategoryName == category);
                        if (category1 != null)
                            categories.Add(category1);
                    }

                }
                if (model.Ingredients != null)
                {
                    foreach (var item in model.Ingredients)
                    {
                        Ingredient ingredient = allIngredients.FirstOrDefault(i => i.IngredientName.ToLower() == item.ToLower().Trim());
                        if (ingredient != null)
                            ingredients.Add(ingredient);
                    }
                }
                for (int a = 0; a < ingredients.Count; a++)
                {
                    RecipeIngredient recipeIngredient = new RecipeIngredient();
                    recipeIngredient.Amount = model.AmountofRecipe[a]; // Use the corresponding amount from the model
                    recipeIngredient.Id = Guid.NewGuid();
                    recipeIngredient.RecipeId = recipe.Id;
                    recipeIngredient.IngredientId = ingredients[a].Id; // Set the IngredientId based on the retrieved ingredient
                    recipeIngredients.Add(recipeIngredient);
                }

                recipe.Ingredients = recipeIngredients;
                recipe.Categories = categories;  
                recipes.Add(recipe);
            }
            bool isOk = await _recipeWriteRepository.AddRangeAsync(recipes);
            await _recipeWriteRepository.SaveAsync();

        }

        return Ok();
    }
    [HttpPost("upload")]
    public async Task<IActionResult> UploadFile(IFormFileCollection files, string recipeName)
    {
        List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("photo-images", files);


        var recipe = await _recipeReadRepository.GetSingleAsync(r => r.RecipeName.ToLower().Trim() == recipeName.ToLower().Trim());


        await _fileWriteRepository.AddRangeAsync(result.Select(r => new Domain.Entities.RecipeImageFile
        {
            FileName = r.fileName,
            Path = r.pathOrContainerName,
            Storage = _storageService.StorageName,
            Recipes = new List<Recipe>() { recipe }
        }).ToList());

        await _fileWriteRepository.SaveAsync();
        return Ok();
    }

}

    
   
       

