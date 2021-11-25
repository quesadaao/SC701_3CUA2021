using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class GroupInvitations
    {
        public int GroupInvitationId { get; set; }
        public string FromUserId { get; set; }
        public int GroupId { get; set; }
        public string ToUserId { get; set; }
        public DateTime SentDate { get; set; }
        public bool Accepted { get; set; }

        public virtual Groups Group { get; set; }
    }
}
