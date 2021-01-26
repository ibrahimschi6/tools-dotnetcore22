using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class ModelMap : EntityTypeConfiguration<Model>
    {
        public ModelMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Models");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BrandId).HasColumnName("BrandId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Specs).HasColumnName("Specs");
            this.Property(t => t.LaunchDate).HasColumnName("LaunchDate");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.Models)
                .HasForeignKey(d => d.BrandId);

        }
    }
}
