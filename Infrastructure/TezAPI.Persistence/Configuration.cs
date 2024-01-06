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
            
            return configurationManager.GetConnectionString("PostgreSQL");
        }
    }

}
