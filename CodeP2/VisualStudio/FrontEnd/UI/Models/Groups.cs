using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Models
{
    public partial class Groups
    {
        public Groups()
        {
            //Foci = new HashSet<Foci>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        //public virtual ICollection<Foci> Foci { get; set; }
    }
}
