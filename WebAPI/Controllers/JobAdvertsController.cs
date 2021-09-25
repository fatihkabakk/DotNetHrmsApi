using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobAdvertsController : ControllerBase
    {
        IJobAdvertService _jobAdvertService;

        public JobAdvertsController(IJobAdvertService jobAdvertService)
        {
            _jobAdvertService = jobAdvertService;
        }

        [HttpPost("add")]
        public IActionResult Add(JobAdvert jobAdvert)
        {
            _jobAdvertService.Add(jobAdvert);
            return CreatedAtAction(nameof(GetById), jobAdvert);
        }

        [HttpPatch("disable")]
        public IActionResult Disable(JobAdvert jobAdvert)
        {
            var advertToDisable = _jobAdvertService.GetById(jobAdvert.Id);
            if (advertToDisable != null)
            {
                _jobAdvertService.Disable(advertToDisable);
                return NoContent();
            }
            return BadRequest();
        }

        [HttpPatch("enable")]
        public IActionResult Enable(JobAdvert jobAdvert)
        {
            var advertToDisable = _jobAdvertService.GetById(jobAdvert.Id);
            if (advertToDisable != null)
            {
                _jobAdvertService.Enable(advertToDisable);
                return NoContent();
            }
            return BadRequest();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _jobAdvertService.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _jobAdvertService.GetAll();

            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getallactiveadvertsorderbycreateddate")]
        public IActionResult GetAllActiveAdvertsOrderByCreatedDate()
        {
            var result = _jobAdvertService.GetAllActiveAdvertsOrderByCreatedDate();
        
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getallactiveadverts")]
        public IActionResult GetAllActiveAdverts()
        {
            var result = _jobAdvertService.GetAllActiveAdverts();

            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getallactiveadvertsbycompany")]
        public IActionResult GetAllActiveAdvertsByCompany(int companyId)
        {
            var result = _jobAdvertService.GetAllActiveAdvertsByCompany(companyId);

            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
