using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_loan.Models;

namespace Vehicle_loan.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class AdminDashboardController : ControllerBase
    {
        public VEHICLE_LOANContext context;

        public AdminDashboardController(VEHICLE_LOANContext e)
        {
            this.context = e;
        }
        
        [Route("api/[controller]")]
        [HttpGet]
       

        public IEnumerable<ViewClientDetails> GetClientDetails()
        {
            return context.ViewClientDetails.ToList();
        }
        
    }
}
