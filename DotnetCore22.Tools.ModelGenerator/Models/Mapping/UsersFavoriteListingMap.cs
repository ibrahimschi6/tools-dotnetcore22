using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class UsersFavoriteListingMap : EntityTypeConfiguration<UsersFavoriteListing>
    {
        public UsersFavoriteListingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("UsersFavoriteListings");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ListingId).HasColumnName("ListingId");
            this.Property(t => t.Date).HasColumnName("Date");

            // Relationships
            this.HasRequired(t => t.Listing)
                .WithMany(t => t.UsersFavoriteListings)
                .HasForeignKey(d => d.ListingId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.UsersFavoriteListings)
                .HasForeignKey(d => d.UserId);

        }
    }
}
