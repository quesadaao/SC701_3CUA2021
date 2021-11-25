using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class CommentUsers
    {
        public int CommentUserId { get; set; }
        public int CommentId { get; set; }
        public string UserId { get; set; }
    }
}
