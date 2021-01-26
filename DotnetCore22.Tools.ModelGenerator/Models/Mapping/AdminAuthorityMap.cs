using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class AdminAuthorityMap : EntityTypeConfiguration<AdminAuthority>
    {
        public AdminAuthorityMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Controller)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Action)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Area)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AdminAuthorities");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Controller).HasColumnName("Controller");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.Area).HasColumnName("Area");

            // Relationships
            this.HasMany(t => t.AdminRoles)
                .WithMany(t => t.AdminAuthorities)
                .Map(m =>
                    {
                        m.ToTable("AdminRoleAuthorieties");
                        m.MapLeftKey("AuthorityId");
                        m.MapRightKey("RoleId");
                    });


        }
    }
}
