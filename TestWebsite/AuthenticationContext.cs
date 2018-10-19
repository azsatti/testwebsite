namespace TestWebsite
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Models;

    public class AuthenticationContext : DbContext
    {
        public AuthenticationContext() : base("AuthenticationContext")
        {
        }

        public DbSet<LoginModel> AuthCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}