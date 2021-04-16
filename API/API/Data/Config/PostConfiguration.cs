using API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Config
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.AuthorName).IsRequired().HasMaxLength(30);
            builder.Property(p => p.Tags).IsRequired().HasMaxLength(100);
        }
    }
}