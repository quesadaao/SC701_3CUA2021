using System;
using System.Collections.Generic;
using System.Text;

namespace BE.DAL.DO.Objects
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
