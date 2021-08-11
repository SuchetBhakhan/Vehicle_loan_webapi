using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class VehicleDetailsTbl
    {
        public VehicleDetailsTbl()
        {
            LoanApplicationTbl = new HashSet<LoanApplicationTbl>();
        }

        public int VId { get; set; }
        public int? CarMakeId { get; set; }
        public decimal? ExShowroomPrice { get; set; }
        public string CarModel { get; set; }

        public virtual CarMakeTbl CarMake { get; set; }
        public virtual ICollection<LoanApplicationTbl> LoanApplicationTbl { get; set; }
    }
}
