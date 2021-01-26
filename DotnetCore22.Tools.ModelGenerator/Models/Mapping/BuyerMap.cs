using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class BuyerMap : EntityTypeConfiguration<Buyer>
    {
        public BuyerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.IdentityNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(20);

            this.Property(t => t.StreetAddress)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.ZipCode)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Buyers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.IdentityNumber).HasColumnName("IdentityNumber");
            this.Property(t => t.CityId).HasColumnName("CityId");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.StreetAddress).HasColumnName("StreetAddress");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.IsAgreementSigned).HasColumnName("IsAgreementSigned");

            // Relationships
            this.HasRequired(t => t.City)
                .WithMany(t => t.Buyers)
                .HasForeignKey(d => d.CityId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Buyers)
                .HasForeignKey(d => d.UserId);

        }
    }
}
