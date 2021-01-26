using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class SellerMap : EntityTypeConfiguration<Seller>
    {
        public SellerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.SubMerchantCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StreetAddress)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.IBAN)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IdentityNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(20);

            this.Property(t => t.TaxOffice)
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .HasMaxLength(150);

            this.Property(t => t.CompanyLegalTitle)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Sellers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.SellerType).HasColumnName("SellerType");
            this.Property(t => t.SubMerchantCode).HasColumnName("SubMerchantCode");
            this.Property(t => t.CityId).HasColumnName("CityId");
            this.Property(t => t.StreetAddress).HasColumnName("StreetAddress");
            this.Property(t => t.IBAN).HasColumnName("IBAN");
            this.Property(t => t.IdentityNumber).HasColumnName("IdentityNumber");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.TaxOffice).HasColumnName("TaxOffice");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.CompanyLegalTitle).HasColumnName("CompanyLegalTitle");
            this.Property(t => t.IsAgreementSigned).HasColumnName("IsAgreementSigned");

            // Relationships
            this.HasRequired(t => t.City)
                .WithMany(t => t.Sellers)
                .HasForeignKey(d => d.CityId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Sellers)
                .HasForeignKey(d => d.UserId);

        }
    }
}
