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
    [Migration("20231226160057_mig3")]
    partial class mig3
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
                            Id = new Guid("27e4cf9f-4ba1-419c-9f9c-08e18d303e9c"),
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8665),
                            Name = "Dairy"
                        },
                        new
                        {
                            Id = new Guid("41205175-cb20-43dc-baaa-b996504417dc"),
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8670),
                            Name = "Gluten"
                        },
                        new
                        {
                            Id = new Guid("df1e56ee-71f9-4f6d-b728-9d596e99a501"),
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8673),
                            Name = "Peanut"
                        },
                        new
                        {
                            Id = new Guid("6ac05c38-78ae-429c-bdae-846e6dc54fcb"),
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8675),
                            Name = "Dessert"
                        },
                        new
                        {
                            Id = new Guid("7682a866-ca12-4432-9e9f-901c873d364f"),
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8677),
                            Name = "Soy"
                        },
                        new
                        {
                            Id = new Guid("a1d13c30-1b83-4710-a818-e687c036f777"),
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8678),
                            Name = "Egg"
                        },
                        new
                        {
                            Id = new Guid("b92417aa-26e1-4444-95f2-5ae7c77db34c"),
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8684),
                            Name = "Seafood"
                        },
                        new
                        {
                            Id = new Guid("5888d76b-e24b-4c3d-b5bd-39255a2b9bbe"),
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8686),
                            Name = "Shellfish"
                        },
                        new
                        {
                            Id = new Guid("cee7aded-f890-477a-9985-e99ecf9b3442"),
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8691),
                            Name = "Pork"
                        },
                        new
                        {
                            Id = new Guid("ff8fa7c7-035f-40c7-9394-31ec357b8a84"),
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8695),
                            Name = "Wheat"
                        },
                        new
                        {
                            Id = new Guid("21f643f8-e5b7-40be-a9a1-82431d3f5b03"),
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8697),
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
                            Id = new Guid("5854d083-5a64-4220-9b55-6a9cdfc09383"),
                            CategoryName = "Beef",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8885)
                        },
                        new
                        {
                            Id = new Guid("b1a9e786-3d0b-42e6-b504-6532b282b01f"),
                            CategoryName = "Breakfast",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8888)
                        },
                        new
                        {
                            Id = new Guid("9521c076-57f1-447e-9680-84a88851269d"),
                            CategoryName = "Chicken",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8890)
                        },
                        new
                        {
                            Id = new Guid("db547e56-9d52-45b7-a66e-8ec9b34ee482"),
                            CategoryName = "Dessert",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8892)
                        },
                        new
                        {
                            Id = new Guid("6d0da6bb-f484-4355-b1ea-dd8fb5b2929d"),
                            CategoryName = "Goat",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8894)
                        },
                        new
                        {
                            Id = new Guid("8bc1df3f-be0e-4893-a72b-c252c63d7310"),
                            CategoryName = "Lamb",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8899)
                        },
                        new
                        {
                            Id = new Guid("e15a6796-6c60-456f-9871-c3175cf39949"),
                            CategoryName = "Miscellaneous",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8901)
                        },
                        new
                        {
                            Id = new Guid("d2e34c9c-bc1e-4380-89d0-1b615b17269c"),
                            CategoryName = "Pasta",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8903)
                        },
                        new
                        {
                            Id = new Guid("4a86aceb-7ae2-48d7-afbb-63b09ca525e3"),
                            CategoryName = "Pork",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8905)
                        },
                        new
                        {
                            Id = new Guid("3ac40351-c38e-4d08-9b45-b1c9741ca870"),
                            CategoryName = "Seafood",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8907)
                        },
                        new
                        {
                            Id = new Guid("cfd67674-6a45-4984-8a9b-3c29ebac1944"),
                            CategoryName = "Side",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8909)
                        },
                        new
                        {
                            Id = new Guid("9ca4b590-082b-44b8-b01d-8fb1f09913c8"),
                            CategoryName = "Starter",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8911)
                        },
                        new
                        {
                            Id = new Guid("ec9bb0bd-873d-4987-b51a-6a05c4cadc2f"),
                            CategoryName = "Vegan",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8913)
                        },
                        new
                        {
                            Id = new Guid("19ee09a2-f8eb-4bd9-9ab4-b08b698ac53b"),
                            CategoryName = "Vegetarian",
                            CreatedDate = new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8917)
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
                        .IsRequired()
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
                        .HasForeignKey("AllergyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
