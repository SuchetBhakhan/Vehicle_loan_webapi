using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class BankPaymentsTbl
    {
        public int Bpid { get; set; }
        public int? Uid { get; set; }
        public int? Ldtid { get; set; }
        public DateTime? MonthlyDate { get; set; }
        public decimal? PrincipalAmmount { get; set; }
        public decimal? Interest { get; set; }
        public int? Status { get; set; }

        public virtual LoanDetailsTbl Ldt { get; set; }
        public virtual UserTbl U { get; set; }
    }
}
