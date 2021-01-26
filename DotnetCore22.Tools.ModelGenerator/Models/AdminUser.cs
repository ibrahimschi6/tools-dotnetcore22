using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class AdminUser
    {
        public AdminUser()
        {
            this.ListingInspectationCycles = new List<ListingInspectationCycle>();
            this.ListingInspectationCycles1 = new List<ListingInspectationCycle>();
            this.ListingValidationCycles = new List<ListingValidationCycle>();
            this.AdminRoles = new List<AdminRole>();
        }

        public System.Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<ListingInspectationCycle> ListingInspectationCycles { get; set; }
        public virtual ICollection<ListingInspectationCycle> ListingInspectationCycles1 { get; set; }
        public virtual ICollection<ListingValidationCycle> ListingValidationCycles { get; set; }
        public virtual ICollection<AdminRole> AdminRoles { get; set; }
    }
}
