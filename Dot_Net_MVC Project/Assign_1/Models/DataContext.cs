using System.Data.Entity;

namespace Assign_1.Models
{
    /*[DbConfigurationType(typeof(MySqlEFConfiguration))]*/
    public class DataContext: DbContext
    {
        public DataContext() : base("DefaultConnection") //This 'DefaultConnection' should be equal to the connection string name on Web.config.
        {
            this.Configuration.ValidateOnSaveEnabled = false;

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Query> Querys { get; set; }

    }


}