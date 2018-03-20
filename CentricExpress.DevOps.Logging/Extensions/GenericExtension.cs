
namespace CentricExpress.DevOps.Logging.Extensions
{
    public static class GenericExtension
    {
        public static string SetConfigValue(this string configKey, string defaultValue)
        {
            if (string.IsNullOrWhiteSpace(configKey))
            {
                return defaultValue;
            }

            var configValue = System.Configuration.ConfigurationManager.AppSettings[configKey];

            return string.IsNullOrWhiteSpace(configValue) ? defaultValue : configValue;
        }
    }
}
