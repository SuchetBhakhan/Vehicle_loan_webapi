using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_loan.Models;

namespace Vehicle_loan.Controllers
{
    [ApiController]
    public class MainController : ControllerBase
    {

        private VEHICLE_LOANContext eContext;

        public MainController(VEHICLE_LOANContext ec)
        {
            this.eContext = ec;
        }

        [Route("api/[controller]")]
        public IActionResult normalGet()
        {
            return Ok();
        }

        [Route("api/[controller]/get-loan-app/{id}")]
        [HttpGet]
        public LoanApplicationTbl get(int id)
        {
            return (from lapp in this.eContext.LoanApplicationTbl where lapp.Lappid == id select lapp).FirstOrDefault();
        }

        [Route("api/[controller]/get-loan-app/")]
        [HttpGet]
        public IActionResult updateLoanApplication(LoanApplicationTbl lapp)
        {
            this.eContext.LoanApplicationTbl.Update(lapp);
            this.eContext.SaveChanges();
            return Ok();
        }


    }
}
