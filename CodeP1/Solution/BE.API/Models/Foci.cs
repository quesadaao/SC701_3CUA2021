using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE.API.Models
{
    public class Foci
    {
        public int FocusId { get; set; }
        public string FocusName { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Groups Group { get; set; }
    }
}
