using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class ToeTbl
    {
        public ToeTbl()
        {
            EmploymentDetailsTbl = new HashSet<EmploymentDetailsTbl>();
        }

        public int Toeid { get; set; }
        public string EmploymentType { get; set; }

        public virtual ICollection<EmploymentDetailsTbl> EmploymentDetailsTbl { get; set; }
    }
}
