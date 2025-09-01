using System;
namespace DB.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "SERVER=localhost;" +
                    "PORT=3306;DATABASE=test_rta_db;USER ID=root; " +
                    "PASSWORD=team@123;Pooling=false;" +
                    "Allow User Variables=True;";
                new loginDBContextFactory().MigrateDbContext(connStr);
                Console.WriteLine("Database Migrated Successfully.");
                Console.ReadLine();

        }
    }
}
