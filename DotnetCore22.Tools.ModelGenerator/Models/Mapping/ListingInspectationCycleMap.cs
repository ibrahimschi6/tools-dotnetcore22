using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class ListingInspectationCycleMap : EntityTypeConfiguration<ListingInspectationCycle>
    {
        public ListingInspectationCycleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AccessoriesDescription)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ListingInspectationCycles");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ListingId).HasColumnName("ListingId");
            this.Property(t => t.InspectorUserId).HasColumnName("InspectorUserId");
            this.Property(t => t.ReviewerUserId).HasColumnName("ReviewerUserId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.ModelId).HasColumnName("ModelId");
            this.Property(t => t.ModelColorId).HasColumnName("ModelColorId");
            this.Property(t => t.ModelStorageId).HasColumnName("ModelStorageId");
            this.Property(t => t.ConditionId).HasColumnName("ConditionId");
            this.Property(t => t.AccessoryDetailsApproved).HasColumnName("AccessoryDetailsApproved");
            this.Property(t => t.AccessoriesDescription).HasColumnName("AccessoriesDescription");
            this.Property(t => t.HasReviewModification).HasColumnName("HasReviewModification");

            // Relationships
            this.HasRequired(t => t.AdminUser)
                .WithMany(t => t.ListingInspectationCycles)
                .HasForeignKey(d => d.InspectorUserId);
            this.HasRequired(t => t.AdminUser1)
                .WithMany(t => t.ListingInspectationCycles1)
                .HasForeignKey(d => d.ReviewerUserId);
            this.HasRequired(t => t.ListingItemCondition)
                .WithMany(t => t.ListingInspectationCycles)
                .HasForeignKey(d => d.ConditionId);
            this.HasRequired(t => t.Listing)
                .WithMany(t => t.ListingInspectationCycles)
                .HasForeignKey(d => d.ListingId);
            this.HasRequired(t => t.ModelColorOption)
                .WithMany(t => t.ListingInspectationCycles)
                .HasForeignKey(d => d.ModelColorId);
            this.HasRequired(t => t.Model)
                .WithMany(t => t.ListingInspectationCycles)
                .HasForeignKey(d => d.ModelId);
            this.HasRequired(t => t.ModelStorageOption)
                .WithMany(t => t.ListingInspectationCycles)
                .HasForeignKey(d => d.ModelStorageId);

        }
    }
}
