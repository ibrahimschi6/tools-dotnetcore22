using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class OrderStateChangeMap : EntityTypeConfiguration<OrderStateChange>
    {
        public OrderStateChangeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("OrderStateChanges");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CurrentStateId).HasColumnName("CurrentStateId");
            this.Property(t => t.PreviousStateId).HasColumnName("PreviousStateId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Date).HasColumnName("Date");

            // Relationships
            this.HasRequired(t => t.Order)
                .WithMany(t => t.OrderStateChanges)
                .HasForeignKey(d => d.OrderId);
            this.HasRequired(t => t.OrderState)
                .WithMany(t => t.OrderStateChanges)
                .HasForeignKey(d => d.CurrentStateId);
            this.HasRequired(t => t.OrderState1)
                .WithMany(t => t.OrderStateChanges1)
                .HasForeignKey(d => d.PreviousStateId);
            this.HasOptional(t => t.User)
                .WithMany(t => t.OrderStateChanges)
                .HasForeignKey(d => d.UserId);

        }
    }
}
