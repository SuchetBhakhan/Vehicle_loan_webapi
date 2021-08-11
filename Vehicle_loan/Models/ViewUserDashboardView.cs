using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class ViewUserDashboardView
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public decimal? ExShowroomPrice { get; set; }
        public decimal? LoanAmmount { get; set; }
        public int? LoanTenure { get; set; }
        public decimal? RateOfInterest { get; set; }
        public int Uid { get; set; }
        public int VId { get; set; }
        public int Lappid { get; set; }
    }
}
