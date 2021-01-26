using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class DailySalePriceMap : EntityTypeConfiguration<DailySalePrice>
    {
        public DailySalePriceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("DailySalePrices");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ModelStorageId).HasColumnName("ModelStorageId");
            this.Property(t => t.RecentSoldAverage).HasColumnName("RecentSoldAverage");
            this.Property(t => t.LastSold).HasColumnName("LastSold");
            this.Property(t => t.LowestCurrent).HasColumnName("LowestCurrent");
            this.Property(t => t.Date).HasColumnName("Date");

            // Relationships
            this.HasRequired(t => t.ModelStorageOption)
                .WithMany(t => t.DailySalePrices)
                .HasForeignKey(d => d.ModelStorageId);

        }
    }
}
