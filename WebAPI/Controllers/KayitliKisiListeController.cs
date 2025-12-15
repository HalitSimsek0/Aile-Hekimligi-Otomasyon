using Business.Services;
using Core.DTO;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class KayitliKisiListeController : ControllerBase
    {
        private readonly KayitliKisiListeService _service;

        public KayitliKisiListeController(KayitliKisiListeService service)
        {
            _service = service;
        }
        [HttpGet("detay/{tc}")]
        public IActionResult TcDetayGetir(string tc)
        {
          
            var kisi = _service.GetAll().FirstOrDefault(x => x.Tc.Trim() == tc.Trim());

            if (kisi == null)
            {
                return NotFound();
            }
            return Ok(kisi);
        }

       
        [HttpGet("varmi/{tc}")]
        public IActionResult TcVarMi(string tc)
        {
      
            bool varMi = _service.GetAll().Any(k => k.Tc.Trim() == tc.Trim());
            return Ok(varMi); 
        }


      
        [HttpGet]
        public IActionResult GetAll()
        {
            var kisiler = _service.GetAll(); 
            return Ok(kisiler);
        }

      
        [HttpPost]
        public IActionResult Add([FromBody] KayitliKisiListeDto model)
        {
            if (model == null)
                return BadRequest("Kayıtlı kişi bilgisi boş olamaz.");

          
            var entity = new KayitliKisiListe
            {
                Tc = model.Tc,
                Ad = model.Ad,
                Soyad = model.Soyad,
                Dogumtarih = model.Dogumtarih,
                AnneAd = model.AnneAd,
                Yas = model.Yas,
                BabaAd = model.BabaAd,
                Telefon = model.Telefon,
                HekimId = model.HekimId
            };

            _service.Add(entity);
            return Ok("Kayıt başarıyla eklendi.");
        }
    }
}
