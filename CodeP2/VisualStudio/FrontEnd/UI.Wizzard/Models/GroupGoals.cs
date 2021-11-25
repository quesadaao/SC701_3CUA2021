using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class GroupGoals
    {
        public int GroupGoalId { get; set; }
        public string GoalName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double? Target { get; set; }
        public int? MetricId { get; set; }
        public int? FocusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int GoalStatusId { get; set; }
        public int GroupUserId { get; set; }
        public int? AssignedGroupUserId { get; set; }
        public string AssignedTo { get; set; }
        public int GroupId { get; set; }
    }
}
