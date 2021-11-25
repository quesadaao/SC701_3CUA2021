using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class FollowUsers
    {
        public int FollowUserId { get; set; }
        public string ToUserId { get; set; }
        public string FromUserId { get; set; }
        public bool Accepted { get; set; }
        public DateTime AddedDate { get; set; }
        public string ApplicationUserId { get; set; }
        public string ApplicationUserId1 { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual AspNetUsers ApplicationUserId1Navigation { get; set; }
        public virtual AspNetUsers FromUser { get; set; }
        public virtual AspNetUsers ToUser { get; set; }
    }
}
