using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class Groups
    {
        public Groups()
        {
            Foci = new HashSet<Foci>();
            GroupInvitations = new HashSet<GroupInvitations>();
            GroupRequests = new HashSet<GroupRequests>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Foci> Foci { get; set; }
        public virtual ICollection<GroupInvitations> GroupInvitations { get; set; }
        public virtual ICollection<GroupRequests> GroupRequests { get; set; }
    }
}
