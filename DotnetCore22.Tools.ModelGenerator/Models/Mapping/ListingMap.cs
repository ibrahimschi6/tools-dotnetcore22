using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class ListingMap : EntityTypeConfiguration<Listing>
    {
        public ListingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Headline)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Description)
                .IsRequired();

            this.Property(t => t.IMEI)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.AccessoriesDescription)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Listings");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.SellerUserId).HasColumnName("SellerUserId");
            this.Property(t => t.ModelId).HasColumnName("ModelId");
            this.Property(t => t.ModelColorId).HasColumnName("ModelColorId");
            this.Property(t => t.ModelStorageId).HasColumnName("ModelStorageId");
            this.Property(t => t.ConditionId).HasColumnName("ConditionId");
            this.Property(t => t.Headline).HasColumnName("Headline");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IMEI).HasColumnName("IMEI");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.AccessoriesDescription).HasColumnName("AccessoriesDescription");
            this.Property(t => t.CityId).HasColumnName("CityId");
            this.Property(t => t.ShowCount).HasColumnName("ShowCount");
            this.Property(t => t.ListingStateId).HasColumnName("ListingStateId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");

            // Relationships
            this.HasRequired(t => t.City)
                .WithMany(t => t.Listings)
                .HasForeignKey(d => d.CityId);
            this.HasRequired(t => t.ListingItemCondition)
                .WithMany(t => t.Listings)
                .HasForeignKey(d => d.ConditionId);
            this.HasRequired(t => t.ListingState)
                .WithMany(t => t.Listings)
                .HasForeignKey(d => d.ListingStateId);
            this.HasRequired(t => t.Model)
                .WithMany(t => t.Listings)
                .HasForeignKey(d => d.ModelId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Listings)
                .HasForeignKey(d => d.SellerUserId);

        }
    }
}
