using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TezAPI.Application;
using TezAPI.Application.Validators.Recipes;
using TezAPI.Infrastructure;
using TezAPI.Infrastructure.Filters;
using TezAPI.Infrastructure.Services.Storage.Local;
using TezAPI.Persistence;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();

builder.Services.AddStorage<LocalStorage>();

builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
   .AddFluentValidation(configurtaion => configurtaion.RegisterValidatorsFromAssemblyContaining<CreateRecipeValidator>())
    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter=true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateAudience = true, //olu�turulacak token de�erini kimlerin /hangi originlerin/sitelerin kullanaca��n� belirledi�imiz de�er.
            ValidateIssuer = true, //Olu�turulacak token de�erini kimin da��tt���n� ifade edece�imiz aland�r
            ValidateLifetime = true, // " "  "   s�resini kontrol edecek olan do�rulamad�r
            ValidateIssuerSigningKey = true, // "" "" ""  uygulamam�za ait0oldu�unu ifade eden security key verisisnin do�rulanmas�d�r.

            ValidAudience = builder.Configuration["Token:Audience"],
            ValidIssuer = builder.Configuration["Token:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
            //LifetimeValidator = (notBefore,expires,securityToken,validationParameters) => expires != null ? expires > DateTime.UtcNow : false
        };
    });

builder.Services.AddAutoMapper(typeof(Program));
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
