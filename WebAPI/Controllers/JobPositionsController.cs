using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPositionsController : ControllerBase
    {
        IJobPositionService _jobPositionService;

        public JobPositionsController(IJobPositionService jobPositionService)
        {
            _jobPositionService = jobPositionService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _jobPositionService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
