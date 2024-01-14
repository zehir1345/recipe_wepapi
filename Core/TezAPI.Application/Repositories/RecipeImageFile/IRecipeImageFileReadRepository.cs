<<<<<<< HEAD
﻿using TezAPI.Domain.Entities;

namespace TezAPI.Application.Repositories;
public interface IRecipeImageFileReadRepository : IReadRepository<TezAPI.Domain.Entities.RecipeImageFile>
{
    List<RecipeImageFile> GetRecipeImages(Guid recipeId);
=======
﻿namespace TezAPI.Application.Repositories;
public interface IRecipeImageFileReadRepository : IReadRepository<TezAPI.Domain.Entities.RecipeImageFile>
{
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
}