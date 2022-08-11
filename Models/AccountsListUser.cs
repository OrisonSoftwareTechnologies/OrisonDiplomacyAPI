using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class AccountsListUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string List { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
