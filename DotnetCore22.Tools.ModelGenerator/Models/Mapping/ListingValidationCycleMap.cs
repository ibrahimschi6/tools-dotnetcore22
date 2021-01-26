using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class ListingValidationCycleMap : EntityTypeConfiguration<ListingValidationCycle>
    {
        public ListingValidationCycleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ListingValidationCycles");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ListingId).HasColumnName("ListingId");
            this.Property(t => t.ValidatorUserId).HasColumnName("ValidatorUserId");
            this.Property(t => t.Date).HasColumnName("Date");

            // Relationships
            this.HasRequired(t => t.AdminUser)
                .WithMany(t => t.ListingValidationCycles)
                .HasForeignKey(d => d.ValidatorUserId);
            this.HasRequired(t => t.Listing)
                .WithMany(t => t.ListingValidationCycles)
                .HasForeignKey(d => d.ListingId);

        }
    }
}
