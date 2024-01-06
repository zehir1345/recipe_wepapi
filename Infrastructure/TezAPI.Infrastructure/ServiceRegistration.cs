using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Abstractions.Storage;
using TezAPI.Application.Abstractions.Token;
using TezAPI.Application.DTOs;
using TezAPI.Infrastructure.Services;
using TezAPI.Infrastructure.Services.Storage;
using TezAPI.Infrastructure.Services.Token;

namespace TezAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection servicesCollection) 
        {
            servicesCollection.AddScoped<IStorageService, StorageService>();
            servicesCollection.AddScoped<ITokenHandler, TokenHandler>();
        }
        public static void AddStorage<T>(this IServiceCollection servicesCollection) where T : Storage , IStorage
        {
            servicesCollection.AddScoped<IStorage, T>();
        }
    }
}
