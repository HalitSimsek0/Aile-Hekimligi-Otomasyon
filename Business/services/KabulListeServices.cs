using Core.DTO;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class KabulListeServices
    {
        private readonly AppDbCon _context;

        public KabulListeServices(AppDbCon context)
        {
            _context = context;
        }

        public List<KabulListeDto> GetAll()
        {
            return _context.KabulListeleri
                .Include(x => x.TamamlanmaDurumu)
                .Select(x => new KabulListeDto
                {
                    Tc = x.Tc,
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                    Dogumtarih = x.Dogumtarih,
                    Yas = x.Yas,
                    TamamlanmaDurumu = x.TamamlanmaDurumu.DurumAdi,
                    OncelikliMi = x.OncelikliMi,
                     HekimId = x.HekimId,
                    Hekim = x.Hekim.Ad + " " + x.Hekim.Soyad
                })
                .ToList();
        }
        public void Add(KabulEkleDto dto)
        {
            try
            {
      
                var kisi = _context.KayitliKisiListesi.FirstOrDefault(x => x.Tc.Trim() == dto.Tc.Trim());
                if (kisi == null)
                    throw new Exception($"TC '{dto.Tc}' ile kayıtlı kişi bulunamadı.");

                var tamamlanmadi = _context.TamamlanmaDurumlari
                    .FirstOrDefault(x => x.DurumAdi == "Tamamlanmadı");
                if (tamamlanmadi == null)
                    throw new Exception("'Tamamlanmadı' durumu sistemde tanımlı değil.");

               
                var kabul = new KabulListe
                {
                    Tc = kisi.Tc,
                    Ad = kisi.Ad,
                    Soyad = kisi.Soyad,
                    Dogumtarih = kisi.Dogumtarih,
                    Yas = kisi.Yas,
                    HekimId = kisi.HekimId,
                    TamamlanmaDurumuId = tamamlanmadi.TamamlanmaDurumuId,
                    OncelikliMi = false
                };

                _context.KabulListeleri.Add(kabul);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Kabul kaydı yapılamadı: {ex.Message}");
            }
        }


    }
}
