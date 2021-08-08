using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class UserIdentityDocsTbl
    {
        public int Uidid { get; set; }
        public int? Uid { get; set; }
        public string AdhaarCard { get; set; }
        public string PanCard { get; set; }
        public string Photo { get; set; }
        public string SalarySlip { get; set; }

        public virtual UserTbl U { get; set; }
    }
}
