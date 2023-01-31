using Elearning.Core.DTO;
using Microsoft.Extensions.Configuration;

namespace Elearning.Core.Extensions
{
    public static class ConfigurationExtension
    {
        public static StorageConfig StorageConfig(this IConfiguration configuration)
        {
            return configuration?.GetSection("StorageConfig")?.Get<StorageConfig>();
        }
    }
}