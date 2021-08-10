using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class LoanApplicationTbl
    {
        public LoanApplicationTbl()
        {
            LoanDetailsTbl = new HashSet<LoanDetailsTbl>();
        }

        public int Lappid { get; set; }
        public int? Uid { get; set; }
        public int? Vid { get; set; }
        public decimal? LoanAmmount { get; set; }
        public int? LoanTenure { get; set; }
        public decimal? RateOfInterest { get; set; }
        public string IsUsed { get; set; }
        public int? Ageold { get; set; }
        public int? StatusId { get; set; }

        public virtual StatusTbl Status { get; set; }
        public virtual UserTbl U { get; set; }
        public virtual VehicleDetailsTbl V { get; set; }
        public virtual ICollection<LoanDetailsTbl> LoanDetailsTbl { get; set; }
    }
}
