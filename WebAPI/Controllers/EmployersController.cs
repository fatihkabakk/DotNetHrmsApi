using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployersController : ControllerBase
    {
        IEmployerService _employerService;
        public EmployersController(IEmployerService employerService)
        {
            _employerService = employerService;
        }

        [HttpPost("add")]
        public IActionResult Add(Employer employer)
        {
            _employerService.Add(employer);
            return CreatedAtAction(nameof(GetById), employer);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employerService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employerService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
