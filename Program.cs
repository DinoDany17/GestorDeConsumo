using dotenv.net;

namespace GestorDeConsumo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Get the current directory of the application
            string appDirectory = Directory.GetCurrentDirectory();
            string cleanAppDirectory = appDirectory.Split("bin")[0];

            //Create the .env file if it does not exist and read the environment variables
            string envPath = Path.Combine(cleanAppDirectory, ".env");
            if (!File.Exists(envPath))
            {
                File.WriteAllText(envPath, "APP_DIRECTORY=" + cleanAppDirectory);
            }
            DotEnv.Load(new DotEnvOptions(envFilePaths: new List<String> { envPath }));

            //Create the database if it does not exist
            DatabaseConnection databaseConnection = new DatabaseConnection();
            if (!File.Exists(databaseConnection.GetDatabaseLocation()))
            {
                databaseConnection.CreateDatabase();
            }

            //ApplicationConfiguration.Initialize();
            //Application.Run(new HomePage());
        }
    }
}