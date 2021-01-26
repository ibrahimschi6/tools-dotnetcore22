using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DotnetCore22.Domain.Model;

namespace DotnetCore22.DataAccess.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.DisplayName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.FirsName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PhotoContentType)
                .HasMaxLength(50);

            this.Property(t => t.ActivationCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AuthorizationSourceId).HasColumnName("AuthorizationSourceId");
            this.Property(t => t.AccountType).HasColumnName("AccountType");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.FirsName).HasColumnName("FirsName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.PhotoContentType).HasColumnName("PhotoContentType");
            this.Property(t => t.FeedbackRank).HasColumnName("FeedbackRank");
            this.Property(t => t.FeedbackCount).HasColumnName("FeedbackCount");
            this.Property(t => t.RegisterDate).HasColumnName("RegisterDate");
            this.Property(t => t.IsAgreementSigned).HasColumnName("IsAgreementSigned");
            this.Property(t => t.ActivationCode).HasColumnName("ActivationCode");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
