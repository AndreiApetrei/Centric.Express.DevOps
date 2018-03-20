using CentricExpress.DevOps.Logging.Extensions;
using CentricExpress.DevOps.Logging.Cons;
using CentricExpress.DevOps.Logging;

namespace CentricExpress.DevOps.LoggingApp
{
    class Program
    {
        static string GetFilePath(string env)
        {
            string filePath = Const.ConfigKeyFilePath.SetConfigValue(Const.DefaultValueFilePath);
            if (!filePath.EndsWith(@"\"))
            {
                filePath = $@"{filePath}\";
            }

            return $@"{filePath}{env}_LoggingFolder\";
        }

        public static void Main(string[] args)
        {
            var log = new LogInFile();
            var env = Const.ConfigKeyEnvironment.SetConfigValue(Const.DefaulValueEnv);

            if (args.Length == 1)
            {
                env = args[0];
            }

            var path = GetFilePath(env);
            log.Run(path, env);
        }
    }
}
