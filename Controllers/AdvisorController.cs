using AdvisorMangementAPI.Interfaces;
using AdvisorMangementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvisorMangementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvisorController : ControllerBase
    {
         readonly IAdvisorRepository advisorRepository;

        public AdvisorController(IAdvisorRepository advisorRepository)
        {
            this.advisorRepository = advisorRepository;
        }

        [HttpGet]
        public IActionResult GetAllAdvisors()
        {
            List<Advisor> advisors = advisorRepository.GetAll();
            if (advisors == null)
            {
                return NotFound(); // Or any other appropriate action
            }
            return Ok(advisors);
        }

        [HttpGet("{id}")]
        public ActionResult<Advisor> GetAdvisorById(int id)
        {
            var advisor = advisorRepository.GetAdvisors(id);
            if (advisor == null)
            {
                return NotFound();
            }
            return Ok(advisor);
        }

        [HttpPost]
        public ActionResult<Advisor> CreateAdvisor(Advisor advisor)
        {
            try
            {
                var createdAdvisor = advisorRepository.Create(advisor);
                return CreatedAtAction(nameof(GetAdvisorById), new { id = createdAdvisor.Id }, createdAdvisor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateAdvisor(int id, Advisor advisor)
        {
            if (id != advisor.Id)
            {
                return BadRequest("Advisor ID mismatch");
            }

            try
            {
                advisorRepository.Update(advisor);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteAdvisor(int id)
        {
            try
            {
                advisorRepository.Delete(id);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
