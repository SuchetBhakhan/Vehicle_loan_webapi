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
    public class UserController : ControllerBase
    {
        private VEHICLE_LOANContext eContext;
        public UserController(VEHICLE_LOANContext e)
        {
            this.eContext = e;
        }


        [Route("api/[controller]/{id}")]
        [HttpGet]
        public ViewUserDashboardView GetUserDetails(int id)
        {
            return (from uLoanA in eContext.ViewUserDashboardView select uLoanA).FirstOrDefault();
        }


        [Route("api/[controller]/temp_user")]
        [HttpPost]
        public IActionResult putData(UserTbl user)
        {
            eContext.UserTbl.Add(user);
            eContext.SaveChanges();
            return Ok();
        }

    }
}
