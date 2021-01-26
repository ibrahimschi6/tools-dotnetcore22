using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class AdminMenuItemMap : EntityTypeConfiguration<AdminMenuItem>
    {
        public AdminMenuItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Url)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("AdminMenuItems");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.Url).HasColumnName("Url");

            // Relationships
            this.HasMany(t => t.AdminRoles)
                .WithMany(t => t.AdminMenuItems)
                .Map(m =>
                    {
                        m.ToTable("AdminRoleMenuItems");
                        m.MapLeftKey("MenuItemId");
                        m.MapRightKey("RoleId");
                    });

            this.HasOptional(t => t.AdminMenuItem1)
                .WithMany(t => t.AdminMenuItems1)
                .HasForeignKey(d => d.ParentId);

        }
    }
}
