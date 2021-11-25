using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class Goals
    {
        public int GoalId { get; set; }
        public string GoalName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double? Target { get; set; }
        public bool GoalType { get; set; }
        public int? MetricId { get; set; }
        public int GoalStatusId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
