using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class AdminRoleMap : EntityTypeConfiguration<AdminRole>
    {
        public AdminRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AdminRoles");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasMany(t => t.AdminUsers)
                .WithMany(t => t.AdminRoles)
                .Map(m =>
                    {
                        m.ToTable("AdminUserRoles");
                        m.MapLeftKey("RoleId");
                        m.MapRightKey("AdminUserId");
                    });


        }
    }
}
