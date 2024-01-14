﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TezAPI.Persistence.Contexts;

#nullable disable

namespace TezAPI.Persistence.Migrations
{
    [DbContext(typeof(TezAPIDbContext))]
    [Migration("20240106121857_mig4")]
    partial class mig4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AllergyUser", b =>
                {
                    b.Property<Guid>("UserAllergiesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserAllergiesId1")
                        .HasColumnType("uuid");

                    b.HasKey("UserAllergiesId", "UserAllergiesId1");

                    b.HasIndex("UserAllergiesId1");

                    b.ToTable("AllergyUser");
                });

            modelBuilder.Entity("CategoryRecipe", b =>
                {
                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecipesId")
                        .HasColumnType("uuid");

                    b.HasKey("CategoriesId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("CategoryRecipe");
                });

            modelBuilder.Entity("CategoryUser", b =>
                {
                    b.Property<Guid>("UserCategoriesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserFavoriteCategoriesId")
                        .HasColumnType("uuid");

                    b.HasKey("UserCategoriesId", "UserFavoriteCategoriesId");

                    b.HasIndex("UserFavoriteCategoriesId");

                    b.ToTable("CategoryUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RecipeRecipeImageFile", b =>
                {
                    b.Property<Guid>("RecipeImageFilesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecipesId")
                        .HasColumnType("uuid");

                    b.HasKey("RecipeImageFilesId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("RecipeRecipeImageFile");
                });

            modelBuilder.Entity("RecipeUser", b =>
                {
                    b.Property<Guid>("FavoriteRecipesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uuid");

                    b.HasKey("FavoriteRecipesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RecipeUser");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Allergy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Allergies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("52bae312-31fe-40d4-9890-9b39fc44046a"),
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5142),
                            Name = "Dairy"
                        },
                        new
                        {
                            Id = new Guid("c6e52986-53e8-4461-819d-44836a9269ef"),
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5145),
                            Name = "Gluten"
                        },
                        new
                        {
                            Id = new Guid("6eb07e38-2851-4350-b6a4-448522960961"),
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5147),
                            Name = "Peanut"
                        },
                        new
                        {
                            Id = new Guid("1da2cc27-d215-41f5-ba1f-f1a2a6ec4e9e"),
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5148),
                            Name = "Dessert"
                        },
                        new
                        {
                            Id = new Guid("fada1ca5-fd49-44ca-8158-a3199611a331"),
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5163),
                            Name = "Soy"
                        },
                        new
                        {
                            Id = new Guid("11342a05-431d-402e-8b95-945e7a8b54d8"),
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5164),
                            Name = "Egg"
                        },
                        new
                        {
                            Id = new Guid("3b966ab8-9124-40e7-9ae8-924c98bfe9d6"),
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5166),
                            Name = "Seafood"
                        },
                        new
                        {
                            Id = new Guid("14f28f66-2023-4c59-b0bc-ef2ac58b9b80"),
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5167),
                            Name = "Shellfish"
                        },
                        new
                        {
                            Id = new Guid("e52508d6-f5bd-403b-84bc-0648cdca0a49"),
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5169),
                            Name = "Pork"
                        },
                        new
                        {
                            Id = new Guid("7d898e27-256b-454e-bc11-945816ee79f9"),
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5170),
                            Name = "Wheat"
                        },
                        new
                        {
                            Id = new Guid("21c47d34-5341-4049-b306-011e8cd4c541"),
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5172),
                            Name = "Sesame"
                        });
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("da16be06-0d9a-41b9-9442-aee38a9c9f3c"),
                            CategoryName = "Beef",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5312)
                        },
                        new
                        {
                            Id = new Guid("fde2dc31-76cc-4577-936f-8db5e688c8d6"),
                            CategoryName = "Breakfast",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5317)
                        },
                        new
                        {
                            Id = new Guid("294a27c6-44ba-47a6-b257-65fc1a45c162"),
                            CategoryName = "Chicken",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5319)
                        },
                        new
                        {
                            Id = new Guid("54e9ba34-dec4-4ac3-a31c-6bf0f6709219"),
                            CategoryName = "Dessert",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5321)
                        },
                        new
                        {
                            Id = new Guid("75c3f772-ec4f-4ecc-8ffa-5c8d33f109f3"),
                            CategoryName = "Goat",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5322)
                        },
                        new
                        {
                            Id = new Guid("b6ba3d23-01d9-4ce8-909a-45befb2fdc2c"),
                            CategoryName = "Lamb",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5324)
                        },
                        new
                        {
                            Id = new Guid("32ab1d88-6f9f-447a-80db-88c23c88bc90"),
                            CategoryName = "Miscellaneous",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5325)
                        },
                        new
                        {
                            Id = new Guid("3ef5b401-3a9a-4f68-aabd-05896386763a"),
                            CategoryName = "Pasta",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5327)
                        },
                        new
                        {
                            Id = new Guid("18252d66-634b-4e54-9b6f-76fd76b73714"),
                            CategoryName = "Pork",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5328)
                        },
                        new
                        {
                            Id = new Guid("79f18845-924e-4e81-a09d-d4e5e32ef9ae"),
                            CategoryName = "Seafood",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5332)
                        },
                        new
                        {
                            Id = new Guid("b5419e65-2ce3-4ead-bb00-05b1c729e571"),
                            CategoryName = "Side",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5333)
                        },
                        new
                        {
                            Id = new Guid("70554f0d-35fc-454d-a941-28c97694eeed"),
                            CategoryName = "Starter",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5335)
                        },
                        new
                        {
                            Id = new Guid("333c31c0-390e-4f55-90fa-3fad68cd31b8"),
                            CategoryName = "Vegan",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5336)
                        },
                        new
                        {
                            Id = new Guid("87c6f14e-2e06-46fd-baff-5892ba5d57c8"),
                            CategoryName = "Vegetarian",
                            CreatedDate = new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5337)
                        });
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.File", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Files");

                    b.HasDiscriminator<string>("Discriminator").HasValue("File");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Identity.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Identity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RefreshTokenEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AllergyId")
                        .HasColumnType("uuid");

                    b.Property<int>("CookingTime")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PreparationTime")
                        .HasColumnType("integer");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecipeText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AllergyId");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.RecipeComment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("RecipeComments");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.RecipeIngredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.RecipeImageFile", b =>
                {
                    b.HasBaseType("TezAPI.Domain.Entities.File");

                    b.HasDiscriminator().HasValue("RecipeImageFile");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.UserImageFile", b =>
                {
                    b.HasBaseType("TezAPI.Domain.Entities.File");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasIndex("UserId");

                    b.HasDiscriminator().HasValue("UserImageFile");
                });

            modelBuilder.Entity("AllergyUser", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Allergy", null)
                        .WithMany()
                        .HasForeignKey("UserAllergiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserAllergiesId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryRecipe", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryUser", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("UserFavoriteCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipeRecipeImageFile", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.RecipeImageFile", null)
                        .WithMany()
                        .HasForeignKey("RecipeImageFilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipeUser", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Recipe", null)
                        .WithMany()
                        .HasForeignKey("FavoriteRecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Identity.AppUser", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Recipe", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Allergy", "Allergy")
                        .WithMany()
                        .HasForeignKey("AllergyId");

                    b.HasOne("TezAPI.Domain.Entities.User", "Writer")
                        .WithMany("Recipes")
                        .HasForeignKey("UserId");

                    b.Navigation("Allergy");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.RecipeComment", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Recipe", "Recipe")
                        .WithMany("Comments")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.RecipeIngredient", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Ingredient", "Ingredient")
                        .WithMany("Recipes")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.UserImageFile", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Ingredient", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Recipe", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
