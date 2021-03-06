using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class UserInfoTbl
    {
        public int Uiid { get; set; }
        public int? Uid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public string Uaddress { get; set; }
        public string Ustate { get; set; }
        public string Ucity { get; set; }
        public string PinCode { get; set; }
        public int? AccountNo { get; set; }

        public virtual BankAccTbl AccountNoNavigation { get; set; }
        public virtual UserTbl U { get; set; }
    }
}
