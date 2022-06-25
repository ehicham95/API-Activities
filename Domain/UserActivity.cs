using System;

namespace Domain
{
    public class UserActivity
    {
        public string AppUserId { get; set; }

        // virtual key word is necessary for lazy loading (or simply classes that are mapped)
        public virtual AppUser AppUser { get; set; }
        public Guid ActivityId { get; set; }

        // virtual key word is necessary for lazy loading (or simply classes that are mapped)
        public virtual Activity Activity { get; set; }
        public DateTime DateJoined { get; set; }
        public bool IsHost { get; set; }
    }
}