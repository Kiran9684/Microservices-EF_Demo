using MedicalStore.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Controllers
{
    [Authorize(Roles = "User")]
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalStoreController : ControllerBase
    {
        IMedicalStoreService _service;
        public MedicalStoreController(IMedicalStoreService service)
        {
            _service = service;
        }

        // GET: api/<ProductController>
        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_service.getStores());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_service.getStoreById(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post(Entities.MedicalStore store)
        {
            try
            {
                _service.addStore(store);
                return Ok("Record Added");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut]

        public IActionResult Put(Entities.MedicalStore store)
        {
            try
            {
                _service.updateStore(store);
                return Ok("Record Update");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                _service.deleteStore(id);
                return Ok("Record Deleted");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
