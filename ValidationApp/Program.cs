using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace ValidationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Build the configuration
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appconfiguration.json")
                .Build();

            // Access the array of data patterns
            var dataPatterns = configuration.GetSection("DataPatterns").Get<DataPattern[]>();

            Logger.Log(Validator.Validate(args, dataPatterns));

        }
    }
}