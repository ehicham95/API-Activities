using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Domain
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public string? Bio { get; set; }
        // virtual key word is necessary for lazy loading (or simply classes that are mapped)
        public virtual ICollection<UserActivity> UserActivities { get; set; }
        public virtual ICollection<Photo>? Photos { get; set; }
        public virtual ICollection<UserFollowing>? Followings { get; set; }
        public virtual ICollection<UserFollowing>? Followers { get; set; }
    }
}