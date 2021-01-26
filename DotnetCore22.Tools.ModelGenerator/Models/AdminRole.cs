using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class AdminRole
    {
        public AdminRole()
        {
            this.AdminAuthorities = new List<AdminAuthority>();
            this.AdminMenuItems = new List<AdminMenuItem>();
            this.AdminUsers = new List<AdminUser>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AdminAuthority> AdminAuthorities { get; set; }
        public virtual ICollection<AdminMenuItem> AdminMenuItems { get; set; }
        public virtual ICollection<AdminUser> AdminUsers { get; set; }
    }
}
