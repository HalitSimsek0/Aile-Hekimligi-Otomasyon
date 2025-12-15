using Business.Services;
using Core.DTO;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MhrsKayitController : ControllerBase
    {
        private readonly MhrsKayitServices _service;

        public MhrsKayitController(MhrsKayitServices service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var mhrsKayitlari = _service.GetAll();
            return Ok(mhrsKayitlari);
        }

        
        [HttpPost]
        public IActionResult Add([FromBody] MhrsKayitDto model)
        {
            if (model == null)
                return BadRequest("Kayıt bilgisi boş olamaz.");

            var entity = new MhrsKayit
            {
                Ad = model.Ad,
                Soyad = model.Soyad,
                Tc = model.Tc,
                Tarih = model.Tarih,
                Saat = model.Saat,
                HekimId = model.HekimId,
                
            };

            _service.Add(entity);
            return Ok("MHRS kaydı başarıyla eklendi.");
        }

    }
}
