using AspNetWebApi.Core.Domain;
using AspNetWebApi.Core.Repositories;
using AspNetWebApi.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;

namespace AspNetWebApi.Persistence
{
    public class ChatContext : DbContext, IChatContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string HOST = Environment.GetEnvironmentVariable("SQL_HOST");
            string PASS = Environment.GetEnvironmentVariable("SA_PASSWORD");
            string CONN_STRING = $"Server={HOST};Database=rpg;User Id=sa;Password={PASS}];";
            optionsBuilder.UseSqlServer(CONN_STRING);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
