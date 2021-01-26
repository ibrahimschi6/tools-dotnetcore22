using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class RecentSoldMap : EntityTypeConfiguration<RecentSold>
    {
        public RecentSoldMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("RecentSold");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ModelStorageId).HasColumnName("ModelStorageId");
            this.Property(t => t.AveragePrice).HasColumnName("AveragePrice");
            this.Property(t => t.LastPrice).HasColumnName("LastPrice");
            this.Property(t => t.LowestPrice).HasColumnName("LowestPrice");
            this.Property(t => t.Count).HasColumnName("Count");
            this.Property(t => t.Date).HasColumnName("Date");

            // Relationships
            this.HasRequired(t => t.ModelStorageOption)
                .WithMany(t => t.RecentSolds)
                .HasForeignKey(d => d.ModelStorageId);

        }
    }
}
