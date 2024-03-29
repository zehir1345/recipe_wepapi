using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TezAPI.Application;
using TezAPI.Application.Validators.Recipes;
using TezAPI.Domain.Entities.Identity;
using TezAPI.Infrastructure;
using TezAPI.Infrastructure.Filters;
using TezAPI.Infrastructure.Services.Storage.Local;
using TezAPI.Persistence;
using TezAPI.Persistence.Contexts;
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
            ValidateAudience = true, //oluşturulacak token değerini kimlerin /hangi originlerin/sitelerin kullanacağını belirlediğimiz değer.
            ValidateIssuer = true, //Oluşturulacak token değerini kimin dağıttığını ifade edeceğimiz alandır
            ValidateLifetime = true, // " "  "   süresini kontrol edecek olan doğrulamadır
            ValidateIssuerSigningKey = true, // "" "" ""  uygulamamıza ait0olduğunu ifade eden security key verisisnin doğrulanmasıdır.

            ValidAudience = builder.Configuration["Token:Audience"],
            ValidIssuer = builder.Configuration["Token:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
            //LifetimeValidator = (notBefore,expires,securityToken,validationParameters) => expires != null ? expires > DateTime.UtcNow : false
        };
    });

builder.Services.AddAutoMapper(typeof(Program));



var app = builder.Build();


// Configure the HTTP request pipeline.
<<<<<<< HEAD
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/
=======
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
<<<<<<< HEAD
app.UseSwagger();
app.UseSwaggerUI();
=======

>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
app.Run();
