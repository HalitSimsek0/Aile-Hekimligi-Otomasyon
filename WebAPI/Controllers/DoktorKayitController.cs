 
using Business.Services;
using Entities;
using Core.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Linq; 

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoktorKayitController : ControllerBase
    {
        private readonly DoktorKayitService _service;

        public DoktorKayitController(DoktorKayitService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Add([FromBody] DoktorKayitDto doktorDto)
        {
            if (doktorDto == null)
                return BadRequest("Doktor bilgisi boş olamaz.");

            try
            {
                var doktorEntity = new DoktorKayit
                {
                    Tc = doktorDto.Tc,
                    Ad = doktorDto.Ad,
                    Soyad = doktorDto.Soyad,
                    Dogumtarih = doktorDto.Dogumtarih,
                    Yas = doktorDto.Yas,
                    Telefon = doktorDto.Telefon,
                    CinsiyetId = doktorDto.CinsiyetId,
                };

                _service.Add(doktorEntity);
                return Ok("Doktor başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doktor eklenirken hata oluştu: {ex.Message}");
                return StatusCode(500, $"Doktor eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var doktorlar = _service.GetAll();
            return Ok(doktorlar);
        }

        
        [HttpGet("enazhastasiolan")]
        public IActionResult GetDoctorWithLeastPatients()
        {
            var doktor = _service.GetDoctorWithLeastPatients();
            if (doktor == null)
            {
                return NotFound("Hiç doktor bulunamadı.");
            }
            
            var doktorDto = new DoktorKayitDto
            {
                 
                Tc = doktor.Tc,
                Ad = doktor.Ad,
                Soyad = doktor.Soyad,
                
            };
            return Ok(doktorDto);
        }

       
        [HttpGet("rastgeledoktor")]
        public IActionResult GetRandomDoctor()
        {
            var doktor = _service.GetRandomDoctor();
            if (doktor == null)
            {
                return NotFound("Hiç doktor bulunamadı.");
            }
           
            var doktorDto = new DoktorKayitDto
            {
                Tc = doktor.Tc,
                Ad = doktor.Ad,
                Soyad = doktor.Soyad,
                
            };
            return Ok(doktorDto);
        }
    }
}