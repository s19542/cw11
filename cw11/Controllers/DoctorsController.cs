using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using cw11.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IHospitalDbService hospitalDbService;

        public DoctorsController(IHospitalDbService _hospitalDbService)
        {
            hospitalDbService = _hospitalDbService;
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                hospitalDbService.Get(id);
            }
            catch (Exception)
            {
                return BadRequest("Exception was caused by getting Doctor "+id);
            }
            return Ok(hospitalDbService.Get(id));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                hospitalDbService.Delete(id);
            }
            catch (Exception)
            {
                return BadRequest("Exception was caused by deleting Doctor with id number " + id);
            }
            return Ok("Deleted id " + id);
        }
        [HttpPost]
        public IActionResult Add(Doctor doctor)
        {
            try
            {
                hospitalDbService.Add(doctor);
            }
            catch (Exception)
            {
                return BadRequest("Exception was caused by adding  new doctor");
            }
            return Ok("Added id "+doctor.IdDoctor);
        }
        [HttpPut]
        public IActionResult ModifyDoctor(Doctor doctor)
        {
            try
            {
                hospitalDbService.Modify(doctor);
            }
            catch (Exception)
            {
                return BadRequest("Exception was caused by modifying doctor");
            }
            return Ok("Modified id " + doctor.IdDoctor);
        }


    }
}