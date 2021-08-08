using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class CarMakeTbl
    {
        public CarMakeTbl()
        {
            VehicleDetailsTbl = new HashSet<VehicleDetailsTbl>();
        }

        public int CarMakeId { get; set; }
        public string CarMake { get; set; }

        public virtual ICollection<VehicleDetailsTbl> VehicleDetailsTbl { get; set; }
    }
}
