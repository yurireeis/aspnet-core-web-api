using AspNetWebApi.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetWebApi.Persistence.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Email).HasMaxLength(255).IsRequired();
            builder.Property(u => u.DisplayName).HasMaxLength(255).IsRequired();
            builder.Property(u => u.Password).IsRequired();
        }
    }
}
