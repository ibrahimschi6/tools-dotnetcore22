using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class ListingAccessoryOptionMap : EntityTypeConfiguration<ListingAccessoryOption>
    {
        public ListingAccessoryOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("ListingAccessoryOptions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasMany(t => t.Listings)
                .WithMany(t => t.ListingAccessoryOptions)
                .Map(m =>
                    {
                        m.ToTable("ListingAccessories");
                        m.MapLeftKey("AccessoryId");
                        m.MapRightKey("ListingId");
                    });


        }
    }
}
