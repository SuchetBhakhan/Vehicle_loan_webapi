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
    public class PersonalInfoController : ControllerBase
    {
        private VEHICLE_LOANContext context;

        public PersonalInfoController(VEHICLE_LOANContext testContext)
        {
            context = testContext;
        }

        [Route("api/[controller]/{id}")]
        public IActionResult Get(int id)
        {
            PersonalInfo p = context.PersonalInfo.Where(user => user.Uid == id).FirstOrDefault();
            if (p == null)
                return BadRequest();
            else
                return Ok(p);
        }
    }
}
