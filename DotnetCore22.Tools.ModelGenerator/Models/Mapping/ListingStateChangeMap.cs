using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class ListingStateChangeMap : EntityTypeConfiguration<ListingStateChange>
    {
        public ListingStateChangeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ListingStateChanges");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ListingId).HasColumnName("ListingId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CurrentStateId).HasColumnName("CurrentStateId");
            this.Property(t => t.PreviousStateId).HasColumnName("PreviousStateId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Date).HasColumnName("Date");

            // Relationships
            this.HasRequired(t => t.Listing)
                .WithMany(t => t.ListingStateChanges)
                .HasForeignKey(d => d.ListingId);
            this.HasRequired(t => t.ListingState)
                .WithMany(t => t.ListingStateChanges)
                .HasForeignKey(d => d.PreviousStateId);
            this.HasRequired(t => t.ListingState1)
                .WithMany(t => t.ListingStateChanges1)
                .HasForeignKey(d => d.CurrentStateId);
            this.HasOptional(t => t.User)
                .WithMany(t => t.ListingStateChanges)
                .HasForeignKey(d => d.UserId);

        }
    }
}
