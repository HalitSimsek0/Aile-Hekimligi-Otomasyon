using Core.DTO;
using Microsoft.AspNetCore.Mvc;
using Business.Services;
using System.Linq;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AramaController : ControllerBase
    {
        private readonly KayitliKisiListeService _kayitliService;
        private readonly MisafirService _misafirService;
        private readonly KabulListeServices _kabulListeService;
        private readonly DoktorKayitService _doktorKayitService;
        private readonly MhrsKayitServices _mhrsKayitService;

        public AramaController(
            KayitliKisiListeService kayitliService,
            MisafirService misafirService,
            KabulListeServices kabulListeService,
            DoktorKayitService doktorKayitService,
            MhrsKayitServices mhrsKayitService
        )
        {
            _kayitliService = kayitliService;
            _misafirService = misafirService;
            _kabulListeService = kabulListeService;
            _doktorKayitService = doktorKayitService;
            _mhrsKayitService = mhrsKayitService;
        }
        [HttpDelete("{kaynak}/{tc}")]
        public IActionResult Sil(string kaynak, string tc)
        {
            switch (kaynak)
            {
                case "Kayitli":
                    _kayitliService.DeleteByTc(tc);
                    break;

                case "Misafir":
                    _misafirService.DeleteByTc(tc);
                    break;

                case "MhrsKayit":
                    _mhrsKayitService.DeleteByTc(tc);
                    break;

                case "DoktorKayit":
                    _doktorKayitService.DeleteByTc(tc);
                    break;

                default:
                    return BadRequest("Geçersiz kaynak");
            }

            return Ok(new { message = "Silme işlemi başarılı" });
        }

        [HttpGet("{kelime}")]
        public IActionResult Ara(string kelime)
        {
            var kayitli = _kayitliService.GetAll()
                .Where(x => x.Tc.Contains(kelime) || x.Ad.Contains(kelime) || x.Soyad.Contains(kelime))
                .Select(x => new AramaDto
                {
                    Kaynak = "Kayitli",
                    Tc = x.Tc,
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                    EkBilgi = x.Hekim 
                });

            var misafir = _misafirService.GetAll()
                .Where(x => x.Tc.Contains(kelime))
                .Select(x => new AramaDto
                {
                    Kaynak = "Misafir",
                    Tc = x.Tc,
                    Ad = "Misafir",   
                    Soyad = "Misafir",
                    EkBilgi = x.Hekim
                });

            var doktorlar = _doktorKayitService.GetAll()
                .Where(x => x.Ad.Contains(kelime) || x.Soyad.Contains(kelime))
                .Select(x => new AramaDto
                {
                    Kaynak = "DoktorKayit",
                    Tc = x.Tc,
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                    EkBilgi = ""
                });

            var mhrsKayitlar = _mhrsKayitService.GetAll()
                .Where(x => x.Tc.Contains(kelime) || x.Ad.Contains(kelime) || x.Soyad.Contains(kelime))
                .Select(x => new AramaDto
                {
                    Kaynak = "MhrsKayit",
                    Tc = x.Tc,
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                    EkBilgi = x.Hekim
                });

            var sonuc = kayitli
                .Concat(misafir)
                .Concat(doktorlar)
                .Concat(mhrsKayitlar)
                .ToList();

            return Ok(sonuc);
        }
    }
}
