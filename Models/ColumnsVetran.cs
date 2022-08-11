using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class ColumnsVetran
    {
        public int Id { get; set; }
        public int Vetid { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public bool Visible { get; set; }
        public bool AllowNull { get; set; }

        public virtual VetypeTran Vet { get; set; }
    }
}
