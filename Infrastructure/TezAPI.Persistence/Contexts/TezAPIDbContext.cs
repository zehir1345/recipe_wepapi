using Microsoft.EntityFrameworkCore;
using TezAPI.Domain.Entities;
using TezAPI.Domain.Entities.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TezAPI.Domain.Entities.Identity;

namespace TezAPI.Persistence.Contexts
{
    public class TezAPIDbContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public TezAPIDbContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<RecipeImageFile> RecipeImagesFiles { get; set; }
        public DbSet<UserImageFile> UserImageFiles { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<RecipeComment> RecipeComments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                data.Entity.CreatedDate = DateTime.UtcNow;
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.Writer)
                .WithMany(u => u.Recipes)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Allergy>().HasData(
                new Allergy() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Dairy" },
                new Allergy() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Gluten" },
                new Allergy() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Peanut" },
                new Allergy() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Dessert" },
                new Allergy() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Soy" },
                new Allergy() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Egg" },
                new Allergy() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Seafood" },
                new Allergy() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Shellfish" },
                new Allergy() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Pork" },
                new Allergy() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Wheat" },
                new Allergy() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Sesame" }
               );
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Beef" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Breakfast" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Chicken" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Dessert" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Goat" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Lamb" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Miscellaneous" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Pasta" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Pork" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Seafood" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Side" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Starter" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Vegan" },
                new Category() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Vegetarian" }
                );

        }
    }
}
