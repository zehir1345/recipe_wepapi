using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace TezAPI.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddMediatR(typeof(ServiceRegistration));
        }
    }
}
