using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductManager.Models;

namespace ProductManager.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(p => p.Description)
            .HasMaxLength(500);

        builder.Property(p => p.SKU)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(p => p.SKU)
            .IsUnique();

        builder.Property(p => p.CostPrice)
            .HasPrecision(12, 2)
            .IsRequired();

        builder.Property(p => p.SalePrice)
            .HasPrecision(12, 2)
            .IsRequired();

        builder.Property(p => p.Quantity)
            .IsRequired();

        builder.Property(p => p.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.ToTable(table =>
        {
            table.HasCheckConstraint(
                "CK_Products_CostPrice",
                "\"CostPrice\" >= 0");

            table.HasCheckConstraint(
                "CK_Products_SalePrice",
                "\"SalePrice\" > 0");

            table.HasCheckConstraint(
                "CK_Products_Quantity",
                "\"Quantity\" >= 0");
        });
    }
}