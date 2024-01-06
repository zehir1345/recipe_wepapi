using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TezAPI.Persistence.Contexts;
using TezAPI.Application.Repositories;
using TezAPI.Persistence.Repository;
using TezAPI.Domain.Entities.Identity;
using TezAPI.Application.Abstractions.Services;
using TezAPI.Persistence.Services;



namespace TezAPI.Persistence;
public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<TezAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString), ServiceLifetime.Scoped);

        services.AddIdentity<AppUser, AppRole>(options =>
        {
            options.Password.RequiredLength = 3;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;           
        }
        ).AddEntityFrameworkStores<TezAPIDbContext>();

        services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
        services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();     
        services.AddScoped<IIngredientReadRepository, IngredientReadRepository>();
        services.AddScoped<IIngredientWriteRepository, IngredientWriteRepository>();
        services.AddScoped<IRecipeReadRepository, RecipeReadRepository>();
        services.AddScoped<IRecipeWriteRepository, RecipeWriteRepository>();
        services.AddScoped<IUserReadRepository, UserReadRepository>();
        services.AddScoped<IUserWriteRepository, UserWriteRepository>();
        services.AddScoped<IFileReadRepository, FileReadRepository>();
        services.AddScoped<IFileWriteRepository, FileWriteRerpositroy>();
        services.AddScoped<IRecipeImageFileReadRepository, RecipeımageFileReadRepository>();
        services.AddScoped<IRecipeImageFileWriteRepository, RecipeImageWriteRepository>();
        services.AddScoped<IAllergyWriteRepository,AllergyWriteRepository>();
        services.AddScoped<IAllergyReadRepository,AllergyReadRepository>();
        services.AddScoped<IRecipeIngredientWriteRepository, RecipeIngredientWriteRepository>();


        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IAuthService, AuthService>();
    }
}
