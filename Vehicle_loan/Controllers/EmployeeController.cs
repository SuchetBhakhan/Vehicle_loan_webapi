using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle_loan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Vehicle_loan.Controllers
{

    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private VEHICLE_LOANContext context;

        public EmployeeController(VEHICLE_LOANContext testContext)
        {
            context = testContext;
        }

        [HttpGet]
        [Route("api/[Controller]")]
        public IEnumerable<EmploymentDetailsTbl> Get()
        {
            return context.EmploymentDetailsTbl.ToList();
        }


        [HttpPost]
        [Route("api/[Controller]")]

        public IActionResult Post(EmploymentDetailsTbl employee)
        {
            context.EmploymentDetailsTbl.Add(employee);
            context.SaveChanges();
            return Ok(employee);
        }

    }
}
