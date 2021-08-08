using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class EmploymentDetailsTbl
    {
        public int Edid { get; set; }
        public int? Uid { get; set; }
        public int? Toeid { get; set; }
        public decimal? YearlyIncome { get; set; }
        public decimal? ExistingEmiMonthly { get; set; }

        public virtual ToeTbl Toe { get; set; }
        public virtual UserTbl U { get; set; }
    }
}
