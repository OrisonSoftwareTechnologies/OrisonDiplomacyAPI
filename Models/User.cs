using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class User
    {
        public User()
        {
            UserRights = new HashSet<UserRight>();
            UsersBranches = new HashSet<UsersBranch>();
            UsersSections = new HashSet<UsersSection>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Category { get; set; }
        public string Section { get; set; }
        public string Status { get; set; }
        public int? AccountId { get; set; }

        public virtual ICollection<UserRight> UserRights { get; set; }
        public virtual ICollection<UsersBranch> UsersBranches { get; set; }
        public virtual ICollection<UsersSection> UsersSections { get; set; }
    }
}
