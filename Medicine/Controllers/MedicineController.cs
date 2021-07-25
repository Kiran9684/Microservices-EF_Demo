using Medicine.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Medicine.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        IMedicineService _service;

        public MedicineController(IMedicineService service)
        {
            _service = service;
        }


        // GET: api/<MedicineController>
        
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok (_service.getMedicines());
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // GET api/<MedicineController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_service.getMedicineById(id));
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // POST api/<MedicineController>
        [HttpPost]
        public IActionResult Post(Models.Medicine medicine)
        {
            try
            {
                _service.addMedicine(medicine);
                return Ok("Data Added Successfully");
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        // PUT api/<MedicineController>/5
        [HttpPut]
        public IActionResult Put(Models.Medicine medicine)
        {
            try
            {
                _service.updateMedicine(medicine);
                return Ok("Record Updated");
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        // DELETE api/<MedicineController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.deleteMedicine(id);
                return Ok("Record Deleted");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
