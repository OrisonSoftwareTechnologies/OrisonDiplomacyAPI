using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class AccountsListMast
    {
        public AccountsListMast()
        {
            AccountsLists = new HashSet<AccountsList>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AccountsList> AccountsLists { get; set; }
    }
}
