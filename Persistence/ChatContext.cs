using AspNetWebApi.Core.Domain;
using AspNetWebApi.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace AspNetWebApi.Persistence
{
    public class ChatContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string CONN_STRING = @"
                Server=localhost;
                Database=rpg;
                User Id=sa;
                Password=d12DSAd12312edsadASDada@!;
            ";
            optionsBuilder.UseSqlServer(CONN_STRING);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
