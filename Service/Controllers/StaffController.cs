using Business.Abstract;
using Business.ValidationRules;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        IStaffService _staffService;


        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var result = _staffService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            var result = _staffService.GetById(id);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost]
        public IActionResult Post([FromBody] Staff staff)
        {
            var result = _staffService.Post(staff);
            if (result.Success == true)
            {
                
                return Ok(result);
            }

            return BadRequest();

        }

        [HttpPut]
        public IActionResult Put([FromBody]Staff staff)
        {

            var result = _staffService.Put(staff);
            if (result.Success == true)
            {
                
                return Ok(result);
            }

            return BadRequest();

        }
        
        [HttpDelete]
        public IActionResult Delete(int id)
        {

            var result = _staffService.Delete(id);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

    }
}
