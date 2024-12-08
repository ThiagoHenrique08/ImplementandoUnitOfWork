using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnitOfWork.Domain.Model;

namespace UnitOfWork.Infrastructure.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductId).HasColumnType("UNIQUEIDENTIFIER").ValueGeneratedOnAdd();
            builder.Property(p=>p.Name).HasColumnType("VARCHAR(50)").IsRequired(false);
            builder.Property(p=>p.Description).HasColumnType("VARCHAR(200)").IsRequired();
            builder.HasOne(p => p.Category).WithMany(c => c.Products).HasPrincipalKey(c => c.CategoryId);
        }
    }
}
