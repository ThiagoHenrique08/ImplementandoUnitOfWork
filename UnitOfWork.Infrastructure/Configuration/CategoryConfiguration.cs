using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnitOfWork.Domain.Model;

namespace UnitOfWork.Infrastructure.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.CategoryId).HasColumnType("UNIQUEIDENTIFIER").ValueGeneratedOnAdd();
            builder.Property(c => c.Name).HasColumnType("VARCHAR(20)").IsRequired(false);
        }
    }
}
