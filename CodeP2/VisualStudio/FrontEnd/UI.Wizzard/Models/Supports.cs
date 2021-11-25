using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class Supports
    {
        public int SupportId { get; set; }
        public int GoalId { get; set; }
        public string UserId { get; set; }
        public DateTime SupportedDate { get; set; }
    }
}
