using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class AdminTbl
    {
        public int Aid { get; set; }
        public string Aname { get; set; }
        public string EmailId { get; set; }
        public string Apassword { get; set; }
    }
}
