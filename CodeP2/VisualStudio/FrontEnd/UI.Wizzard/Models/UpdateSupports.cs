using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class UpdateSupports
    {
        public int UpdateSupportId { get; set; }
        public int UpdateId { get; set; }
        public string UserId { get; set; }
        public DateTime UpdateSupportedDate { get; set; }
    }
}
