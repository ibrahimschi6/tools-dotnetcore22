using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PaymentReferanceCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PaymentTransactionCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Orders");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ListingId).HasColumnName("ListingId");
            this.Property(t => t.BuyerUserId).HasColumnName("BuyerUserId");
            this.Property(t => t.OrderStateId).HasColumnName("OrderStateId");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            this.Property(t => t.SellerAmount).HasColumnName("SellerAmount");
            this.Property(t => t.PaymentSystemAmount).HasColumnName("PaymentSystemAmount");
            this.Property(t => t.SystemAmount).HasColumnName("SystemAmount");
            this.Property(t => t.InstallmentCount).HasColumnName("InstallmentCount");
            this.Property(t => t.PaymentReferanceCode).HasColumnName("PaymentReferanceCode");
            this.Property(t => t.PaymentTransactionCode).HasColumnName("PaymentTransactionCode");
            this.Property(t => t.IsMoneyDistributed).HasColumnName("IsMoneyDistributed");
            this.Property(t => t.IsCurrent).HasColumnName("IsCurrent");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");

            // Relationships
            this.HasRequired(t => t.Listing)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.ListingId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.BuyerUserId);

        }
    }
}
