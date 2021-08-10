using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class UserTbl
    {
        public UserTbl()
        {
            EmploymentDetailsTbl = new HashSet<EmploymentDetailsTbl>();
            LoanApplicationTbl = new HashSet<LoanApplicationTbl>();
            LoanDetailsTbl = new HashSet<LoanDetailsTbl>();
            UserIdentityDocsTbl = new HashSet<UserIdentityDocsTbl>();
            UserInfoTbl = new HashSet<UserInfoTbl>();
        }

        public int Uid { get; set; }
        public string EmailId { get; set; }
        public string Apassword { get; set; }

        public virtual ICollection<EmploymentDetailsTbl> EmploymentDetailsTbl { get; set; }
        public virtual ICollection<LoanApplicationTbl> LoanApplicationTbl { get; set; }
        public virtual ICollection<LoanDetailsTbl> LoanDetailsTbl { get; set; }
        public virtual ICollection<UserIdentityDocsTbl> UserIdentityDocsTbl { get; set; }
        public virtual ICollection<UserInfoTbl> UserInfoTbl { get; set; }
    }
}
