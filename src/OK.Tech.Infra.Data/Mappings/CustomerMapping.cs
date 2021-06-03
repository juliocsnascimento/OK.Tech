using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OK.Tech.Domain.Entities;

namespace OK.Tech.Infra.Data.Mappings
{
  public class CustomerMapping : IEntityTypeConfiguration<Customer>
  {
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
      builder.HasKey(p => p.Id);

      builder.Property(p => p.Name).IsRequired().HasMaxLength(200).HasColumnType("VARCHAR(200)");

      builder.Property(p => p.Birthdate).IsRequired().HasColumnType("DATE");

      builder.Property(p => p.Phone).IsRequired().HasMaxLength(15).HasColumnType("VARCHAR(15)");

      builder.Property(p => p.Email).IsRequired().HasMaxLength(200).HasColumnType("VARCHAR(200)");

      builder.Property(p => p.Active).IsRequired();

      builder.ToTable("Customer");
    }
  }
}
