using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class BankAccTbl
    {
        public BankAccTbl()
        {
            UserInfoTbl = new HashSet<UserInfoTbl>();
        }

        public int Bid { get; set; }
        public string AccountNo { get; set; }

        public virtual ICollection<UserInfoTbl> UserInfoTbl { get; set; }
    }
}
