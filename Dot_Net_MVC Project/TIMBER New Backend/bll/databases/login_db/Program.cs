using System;
namespace DB.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "SERVER=localhost;" +
                    "PORT=3306;DATABASE=timber_db;USER ID=root; " +
                    "PASSWORD=team@123;Pooling=false;" +
                    "Allow User Variables=True;";
            new loginDBContextFactory().MigrateDbContext(connStr);
            Console.WriteLine("Database Migrated Successfully.");
            Console.ReadLine();

        }
    }

}


/*
using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DB.Login
{
    class Program
    {
        static void Main(string[] args)
        {

            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..");

            // Build the configuration
            var config = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Get the connection string from the configuration
            string connStr = config.GetConnectionString("DefaultConnection");

            // Use the connection string
            new loginDBContextFactory().MigrateDbContext(connStr);
            Console.WriteLine("Database Migrated Successfully.");
            Console.ReadLine();
        }
    }
}

*/