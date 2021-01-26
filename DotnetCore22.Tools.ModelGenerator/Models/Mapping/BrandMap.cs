using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class BrandMap : EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FullCompanyName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Brands");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FullCompanyName).HasColumnName("FullCompanyName");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
