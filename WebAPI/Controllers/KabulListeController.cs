using Business.Services;
using Core.DTO;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KabulListeController : ControllerBase
    {
        private readonly KabulListeServices _service;

        public KabulListeController(KabulListeServices service)
        {
            _service = service;
        }

      
        [HttpGet]
        public IActionResult GetAll()
        {
            var liste = _service.GetAll();
            return Ok(liste);
        }
        [HttpGet("doktor/{hekimId}")]
        public IActionResult GetByDoktor(int hekimId)
        {
            var liste = _service.GetAll()
                .Where(x => x.HekimId == hekimId)
                .ToList();

            return Ok(liste);
        }

        [HttpPost]
        public IActionResult Add([FromBody] KabulEkleDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Tc))
                return BadRequest("TC bilgisi eksik.");

            try
            {
                _service.Add(dto);
                return Ok("Kabul kaydı başarıyla yapıldı.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Hata: {ex.Message}");
            }
        }

      

    }
}
