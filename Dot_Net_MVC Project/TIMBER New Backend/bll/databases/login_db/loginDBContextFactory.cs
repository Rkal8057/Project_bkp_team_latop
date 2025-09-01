using DB.Login.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DB.Login
{
    public class DataSeeder
    {
        public static void Seed(loginDBContext context)
        {
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "SeederFile");

            


            DatabaseSeeder.SeedData<User_Profile_Master>(context, Path.Combine(basePath, "user_profile_master.json"));
            DatabaseSeeder.SeedData<User_Detail>(context, Path.Combine(basePath, "user_detail.json"));
            DatabaseSeeder.SeedData<System_Records>(context, Path.Combine(basePath, "system_record.json"));
            DatabaseSeeder.SeedData<HelperFlagMaster>(context, Path.Combine(basePath, "helper_flag_master.json"));
            DatabaseSeeder.SeedData<HelperMaster>(context, Path.Combine(basePath, "helper_master.json"));
            DatabaseSeeder.SeedData<Form_Master>(context, Path.Combine(basePath, "form_master.json"));
            DatabaseSeeder.SeedData<Multi_Purpose_Type_Master>(context, Path.Combine(basePath, "multi_purpose_type_master.json"));
            DatabaseSeeder.SeedData<State_Master>(context, Path.Combine(basePath, "state_master.json"));
            DatabaseSeeder.SeedData<vou_list_master>(context, Path.Combine(basePath, "vou_list_master.json"));


            //DatabaseSeeder.SeedData<Sms_Msg_Master>(context, "sms.json");
            //DatabaseSeeder.SeedData<Comp_Name>(context, "compSystemData.json");
            //DatabaseSeeder.SeedData<Req_Category_Online_Web_Master>(context, "reqCategory.json");
            //DatabaseSeeder.SeedData<Req_SubCategory_Online_Web_Master>(context, "reqSubCategory.json");
            //DatabaseSeeder.SeedData<Req_Web_Checklist_Master>(context, "reqChecklist.json");
        }
    }

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
                "PORT=3306;DATABASE=timber_db;USER ID=root; " +
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
            // Seed data
            DataSeeder.Seed(context);
            return context;
        }
    }
}
