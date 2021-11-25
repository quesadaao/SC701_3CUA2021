using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class FollowRequests
    {
        public int FollowRequestId { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public bool Accepted { get; set; }
    }
}
