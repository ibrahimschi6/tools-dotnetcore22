using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class ModelStorageOptionMap : EntityTypeConfiguration<ModelStorageOption>
    {
        public ModelStorageOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("ModelStorageOptions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Modeld).HasColumnName("Modeld");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.Model)
                .WithMany(t => t.ModelStorageOptions)
                .HasForeignKey(d => d.Modeld);

        }
    }
}
