using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class GroupUsers
    {
        public int GroupUserId { get; set; }
        public int GroupId { get; set; }
        public string UserId { get; set; }
        public bool Admin { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
