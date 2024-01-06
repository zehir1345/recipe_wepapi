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
            ValidateAudience = true, //oluþturulacak token deðerini kimlerin /hangi originlerin/sitelerin kullanacaðýný belirlediðimiz deðer.
            ValidateIssuer = true, //Oluþturulacak token deðerini kimin daðýttýðýný ifade edeceðimiz alandýr
            ValidateLifetime = true, // " "  "   süresini kontrol edecek olan doðrulamadýr
            ValidateIssuerSigningKey = true, // "" "" ""  uygulamamýza ait0olduðunu ifade eden security key verisisnin doðrulanmasýdýr.

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
