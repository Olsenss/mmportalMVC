using System.Data.Entity;

namespace mmportalMVC.Models
{
    public class DB_Entities : DbContext
    {
        public DB_Entities() : base("mellemmanden") { }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            base.OnModelCreating(modelBuilder);
        }
    }
}