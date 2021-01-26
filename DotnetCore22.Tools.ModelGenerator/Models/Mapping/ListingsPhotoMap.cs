using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class ListingsPhotoMap : EntityTypeConfiguration<ListingsPhoto>
    {
        public ListingsPhotoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Photo)
                .IsRequired();

            this.Property(t => t.PhotoContentType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ListingsPhotos");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ListingId).HasColumnName("ListingId");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.PhotoContentType).HasColumnName("PhotoContentType");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");

            // Relationships
            this.HasRequired(t => t.Listing)
                .WithMany(t => t.ListingsPhotos)
                .HasForeignKey(d => d.ListingId);

        }
    }
}
