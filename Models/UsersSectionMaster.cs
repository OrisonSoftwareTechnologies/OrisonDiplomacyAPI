using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class UsersSectionMaster
    {
        public UsersSectionMaster()
        {
            UsersSections = new HashSet<UsersSection>();
        }

        public int Id { get; set; }
        public string Section { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<UsersSection> UsersSections { get; set; }
    }
}
