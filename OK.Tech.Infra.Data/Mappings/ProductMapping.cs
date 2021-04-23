using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OK.Tech.Domain.Entities;

namespace OK.Tech.Infra.Data.Mappings
{
  public class ProductMapping : IEntityTypeConfiguration<Product>
  {
    public void Configure(EntityTypeBuilder<Product> builder)
    {
      builder.HasKey(p => p.Id);
      builder.Property(p => p.Name).IsRequired().HasColumnType("VARCHAR(200)").HasMaxLength(200);
      builder.Property(p => p.Description).IsRequired().HasColumnType("VARCHAR(1000)").HasMaxLength(1000);
      builder.Property(p => p.Active).IsRequired();
      builder.ToTable("Products");
    }
  }
}
