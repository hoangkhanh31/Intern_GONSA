using API.Interface;
using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CbnvGonsaController : ControllerBase
    {
        private ICbnvGonsaRepository _repository;

        public CbnvGonsaController(ICbnvGonsaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_repository.GetAll());
            }
            catch
            {
                //return StatusCode(StatusCodes.Status500InternalServerError); 
                return BadRequest(400);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(string id)
        {
            try
            {
                var data = _repository.GetCbnvGonsaByID(id);
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        public IActionResult Update(CbnvGonsa item)
        {
            try
            {
                _repository.UpdateCbnvGonsa(item);
                return NoContent();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                _repository.DeleteCbnvGonsaByID(id);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult Add(CbnvGonsa item)
        {
            try
            {
                _repository.AddCbnvGonsa(item);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
