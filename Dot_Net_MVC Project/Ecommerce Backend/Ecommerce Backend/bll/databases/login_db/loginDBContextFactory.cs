using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Login
{
    public class loginDBContextFactory : IDesignTimeDbContextFactory<loginDBContext>
    {
        MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8,0));
        public static loginDBContext Create(string _ConnString)
        {
            MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8,0));
            var optionsBuilder = new DbContextOptionsBuilder<loginDBContext>();
            optionsBuilder.UseMySql(_ConnString, serverVersion);

            //Ensure database creation
            var contextAdmin = new loginDBContext(optionsBuilder.Options);
            // contextAdmin.Database.EnsureCreated();
            return contextAdmin;
        }

        public loginDBContext CreateDbContext(string[] args)
        {
            string connStr = "SERVER=localhost;" +
                "PORT=3306;DATABASE=EcommerceDB;USER ID=root; " +
                "PASSWORD=team@123;Pooling=false;" +
                "Allow User Variables=True;";
            var optionsBuilder = new DbContextOptionsBuilder<loginDBContext>();
            optionsBuilder.UseMySql(connStr, serverVersion);
            //Ensure database creation and migration
            var context = new loginDBContext(optionsBuilder.Options);
            context.Database.Migrate();
            return context;
        }

        public loginDBContext MigrateDbContext(string connStr)
        {
            var optionsBuilder = new DbContextOptionsBuilder<loginDBContext>();
            optionsBuilder.UseMySql(connStr, serverVersion);
            //Ensure database creation and migration
            var context = new loginDBContext(optionsBuilder.Options);
            context.Database.Migrate();
            return context;
        }
    }
}
