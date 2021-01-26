using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class ListingsCommentMap : EntityTypeConfiguration<ListingsComment>
    {
        public ListingsCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ListingsComments");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ListingId).HasColumnName("ListingId");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.CommentDate).HasColumnName("CommentDate");

            // Relationships
            this.HasRequired(t => t.Listing)
                .WithMany(t => t.ListingsComments)
                .HasForeignKey(d => d.ListingId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.ListingsComments)
                .HasForeignKey(d => d.UserId);

        }
    }
}
