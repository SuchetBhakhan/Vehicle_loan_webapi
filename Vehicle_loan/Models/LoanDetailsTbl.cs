using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class LoanDetailsTbl
    {
        public int Ldtid { get; set; }
        public int? Lappid { get; set; }
        public int? Uid { get; set; }
        public DateTime? ApprovedOn { get; set; }

        public virtual LoanApplicationTbl Lapp { get; set; }
        public virtual UserTbl U { get; set; }
    }
}
