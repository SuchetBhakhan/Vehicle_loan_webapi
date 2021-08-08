using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class StatusTbl
    {
        public StatusTbl()
        {
            LoanApplicationTbl = new HashSet<LoanApplicationTbl>();
        }

        public int StatusId { get; set; }
        public string StatusVal { get; set; }

        public virtual ICollection<LoanApplicationTbl> LoanApplicationTbl { get; set; }
    }
}
