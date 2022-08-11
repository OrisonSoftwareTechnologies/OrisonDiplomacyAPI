using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class UserRightsTemplate
    {
        public int Id { get; set; }
        public string Template { get; set; }
        public int KeywordId { get; set; }
        public bool AllowOpen { get; set; }
        public bool AllowAdd { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowPrint { get; set; }

        public virtual UserRightsMaster Keyword { get; set; }
    }
}
