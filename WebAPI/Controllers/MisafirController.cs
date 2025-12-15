 
using Business.Services;
using Core.DTO; 
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MisafirController : ControllerBase
    {
        private readonly MisafirService _service;

        public MisafirController(MisafirService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var misafirler = _service.GetAll();
            return Ok(misafirler);
        }


        [HttpPost]
        public IActionResult Add([FromBody] MisafirDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Tc) || dto.HekimId == 0)
                return BadRequest("Eksik veya geçersiz bilgi.");

            _service.Add(dto);  
            return Ok(dto);     
        }
    }

}
