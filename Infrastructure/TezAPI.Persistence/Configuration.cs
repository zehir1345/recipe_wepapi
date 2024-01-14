using Microsoft.Extensions.Configuration;

namespace TezAPI.Persistence;
static class Configuration
{
    static public string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
         
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/TezAPI.Presentation"));
                configurationManager.AddJsonFile("appsettings.json");
            
<<<<<<< HEAD
            return configurationManager.GetConnectionString("MsSql");
=======
            return configurationManager.GetConnectionString("PostgreSQL");
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
        }
    }

}
