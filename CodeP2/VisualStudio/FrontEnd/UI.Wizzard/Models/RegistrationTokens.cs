using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class RegistrationTokens
    {
        public int RegistrationTokenId { get; set; }
        public Guid Token { get; set; }
        public string Role { get; set; }
    }
}
