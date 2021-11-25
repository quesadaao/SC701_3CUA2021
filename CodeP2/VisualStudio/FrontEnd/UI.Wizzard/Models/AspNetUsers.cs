using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            FollowUsersApplicationUser = new HashSet<FollowUsers>();
            FollowUsersApplicationUserId1Navigation = new HashSet<FollowUsers>();
            FollowUsersFromUser = new HashSet<FollowUsers>();
            FollowUsersToUser = new HashSet<FollowUsers>();
            Goals = new HashSet<Goals>();
            GroupRequests = new HashSet<GroupRequests>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicUrl { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public bool? Activated { get; set; }
        public int? RoleId { get; set; }
        public string Discriminator { get; set; }

        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<FollowUsers> FollowUsersApplicationUser { get; set; }
        public virtual ICollection<FollowUsers> FollowUsersApplicationUserId1Navigation { get; set; }
        public virtual ICollection<FollowUsers> FollowUsersFromUser { get; set; }
        public virtual ICollection<FollowUsers> FollowUsersToUser { get; set; }
        public virtual ICollection<Goals> Goals { get; set; }
        public virtual ICollection<GroupRequests> GroupRequests { get; set; }
    }
}
