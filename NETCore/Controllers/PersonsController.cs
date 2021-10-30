using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NETCore.Models;
using NETCore.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCore.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly PersonRepository personRepository;

        public PersonsController(PersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        // get
        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                var data = personRepository.GetAll();
                return Ok(new { status = 200, message = "success", data });
            }
            catch
            {
                return NotFound(personRepository.GetAll());
            }
        }
        // get by id
        [HttpGet("{NIK}")]
        public ActionResult GetById(string NIK)
        {
            try
            {
                var data = personRepository.GetById(NIK);
                return Ok(new { status = 200, message = "success", data });
            }
            catch
            {
                return NotFound();
            }
        }
        // post
        [HttpPost]
        public ActionResult Insert(Person person)
        {
            try
            {
                personRepository.Insert(person);
                return Ok(new { status = 200, message = "success insert data"});
            }
            catch
            {

                return BadRequest();
            }
        }
        // delete
        [HttpDelete("{NIK}")]
        public ActionResult Delete(string NIK)
        {
            try
            {
                personRepository.Delete(NIK);
                return Ok(new { status = 200, message = "success delete data" });
            }
            catch
            {

                return BadRequest();
            }
        }

        // update
        [HttpPut]
        public ActionResult Update(Person person)
        {
            try
            {
                personRepository.Update(person);
                return Ok(new { status = 200, message = "success update data" });
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
