using System;
namespace DB.RTAComp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "SERVER=localhost;" +
                "PORT=3306;DATABASE=test_rtacomp_db;USER ID=root; " +
                "PASSWORD=mkiasdP123;Pooling=false;" +
                "Allow User Variables=True;";
                new compDbContextFactory().MigrateDbContext(connStr);
                Console.WriteLine("Database Migrated Successfully.");
                Console.ReadLine();

        }
    }
}
