using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.RTAComp
{
    public class compDbContextFactory : IDesignTimeDbContextFactory<compDbContext>
    {
        MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8,0));
        public static compDbContext Create(string _ConnString)
        {
            MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8,0));
            var optionsBuilder = new DbContextOptionsBuilder<compDbContext>();
            optionsBuilder.UseMySql(_ConnString, serverVersion);

            //Ensure database creation
            var contextAdmin = new compDbContext(optionsBuilder.Options);
            // contextAdmin.Database.EnsureCreated();
            return contextAdmin;
        }

        public compDbContext CreateDbContext(string[] args)
        {
            string connStr = "SERVER=localhost;" +
                "PORT=3306;DATABASE=test_rtacomp_db;USER ID=root; " +
                "PASSWORD=mkiasdP123;Pooling=false;" +
                "Allow User Variables=True;";
            var optionsBuilder = new DbContextOptionsBuilder<compDbContext>();
            optionsBuilder.UseMySql(connStr, serverVersion);
            //Ensure database creation and migration
            var context = new compDbContext(optionsBuilder.Options);
            context.Database.Migrate();
            return context;
        }

        public compDbContext MigrateDbContext(string connStr)
        {
            var optionsBuilder = new DbContextOptionsBuilder<compDbContext>();
            optionsBuilder.UseMySql(connStr, serverVersion);
            //Ensure database creation and migration
            var context = new compDbContext(optionsBuilder.Options);
            context.Database.Migrate();
            return context;
        }
    }
}
