using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class GroupUpdates
    {
        public GroupUpdates()
        {
            GroupComments = new HashSet<GroupComments>();
            GroupUpdateSupports = new HashSet<GroupUpdateSupports>();
        }

        public int GroupUpdateId { get; set; }
        public string Updatemsg { get; set; }
        public double? Status { get; set; }
        public int GroupGoalId { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<GroupComments> GroupComments { get; set; }
        public virtual ICollection<GroupUpdateSupports> GroupUpdateSupports { get; set; }
    }
}
