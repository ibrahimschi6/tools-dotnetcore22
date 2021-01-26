using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class AdminMenuItem
    {
        public AdminMenuItem()
        {
            this.AdminMenuItems1 = new List<AdminMenuItem>();
            this.AdminRoles = new List<AdminRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Url { get; set; }
        public virtual ICollection<AdminMenuItem> AdminMenuItems1 { get; set; }
        public virtual AdminMenuItem AdminMenuItem1 { get; set; }
        public virtual ICollection<AdminRole> AdminRoles { get; set; }
    }
}
