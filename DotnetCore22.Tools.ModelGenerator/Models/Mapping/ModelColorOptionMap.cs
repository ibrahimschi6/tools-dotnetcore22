using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class ModelColorOptionMap : EntityTypeConfiguration<ModelColorOption>
    {
        public ModelColorOptionMap()
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
            this.ToTable("ModelColorOptions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Modeld).HasColumnName("Modeld");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.Model)
                .WithMany(t => t.ModelColorOptions)
                .HasForeignKey(d => d.Modeld);

        }
    }
}
