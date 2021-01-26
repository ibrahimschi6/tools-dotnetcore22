using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class FeedbackMap : EntityTypeConfiguration<Feedback>
    {
        public FeedbackMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Feedbacks");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.ListingId).HasColumnName("ListingId");
            this.Property(t => t.BuyerUserId).HasColumnName("BuyerUserId");
            this.Property(t => t.SellerUserId).HasColumnName("SellerUserId");
            this.Property(t => t.Point).HasColumnName("Point");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Date).HasColumnName("Date");

            // Relationships
            this.HasRequired(t => t.Listing)
                .WithMany(t => t.Feedbacks)
                .HasForeignKey(d => d.ListingId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Feedbacks)
                .HasForeignKey(d => d.BuyerUserId);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.Feedbacks1)
                .HasForeignKey(d => d.SellerUserId);

        }
    }
}
