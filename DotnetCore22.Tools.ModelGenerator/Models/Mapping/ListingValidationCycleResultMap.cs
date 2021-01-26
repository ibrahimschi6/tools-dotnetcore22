using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class ListingValidationCycleResultMap : EntityTypeConfiguration<ListingValidationCycleResult>
    {
        public ListingValidationCycleResultMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ListingValidationCycleResults");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ListingCycleId).HasColumnName("ListingCycleId");
            this.Property(t => t.CheckItemId).HasColumnName("CheckItemId");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.ListingValidationCheckItem)
                .WithMany(t => t.ListingValidationCycleResults)
                .HasForeignKey(d => d.CheckItemId);
            this.HasRequired(t => t.ListingValidationCycle)
                .WithMany(t => t.ListingValidationCycleResults)
                .HasForeignKey(d => d.ListingCycleId);

        }
    }
}
