using Microsoft.EntityFrameworkCore;

namespace Web_API.Models
{
    public class DBContext :DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        // Define your database tables as DbSet properties 
        public DbSet<User> Users { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Token> Tokens { get; set; }

        // Optionally, you can override the OnModelCreating method to configure entity relationships
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity relationships and constraints here
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=lbs; User Id=sa; password=123; TrustServerCertificate= True");
        }*/

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configure the relationship between User and File
        //    modelBuilder.Entity<File>()
        //        .HasOne(b => b.User)
        //        .WithMany(a => a.Files)
        //        .HasForeignKey(b => b.userId);
        //}
    }
}
