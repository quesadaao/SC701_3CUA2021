using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class Updates
    {
        public int UpdateId { get; set; }
        public string Updatemsg { get; set; }
        public double? Status { get; set; }
        public int GoalId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
