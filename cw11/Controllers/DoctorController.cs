using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly HospitalDbContext _hospitalDbContext;

        public DoctorController(HospitalDbContext hospitalDbContext) 
        {
            _hospitalDbContext = hospitalDbContext;
        }

        [HttpGet]
        public IActionResult GetDoctor()
        {
            return Ok();
           // return Ok(_hospitalDbContext.Doctor.ToList());
        }

    }
}