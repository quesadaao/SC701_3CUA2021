using System;
using System.Collections.Generic;
using System.Text;

namespace BE.DAL.DO.Objects
{
    public class Groups
    {
        public Groups()
        {
            Foci = new HashSet<Foci>();
            //GroupInvitations = new HashSet<GroupInvitations>();
            //GroupRequests = new HashSet<GroupRequests>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Foci> Foci { get; set; }
        //public virtual ICollection<GroupInvitations> GroupInvitations { get; set; }
        //public virtual ICollection<GroupRequests> GroupRequests { get; set; }
    }
}
