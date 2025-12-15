using Core.DTO;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class KayitliKisiListeService
    {
        private readonly AppDbCon _context;

        public KayitliKisiListeService(AppDbCon context)
        {
            _context = context;
        }

        public void Add(KayitliKisiListe kisi)
        {
            _context.KayitliKisiListesi.Add(kisi);
            _context.SaveChanges();
        }

        public List<KayitliKisiListeDto> GetAll()
        {
            return _context.KayitliKisiListesi
                .Include(x => x.Hekim)
                .Select(x => new KayitliKisiListeDto
                {
                    Tc = x.Tc,
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                    Dogumtarih = x.Dogumtarih,
                    AnneAd = x.AnneAd,
                    Yas = x.Yas,
                    BabaAd = x.BabaAd,
                    Telefon = x.Telefon,
                    Hekim = x.Hekim.Ad + " " + x.Hekim.Soyad,
                    HekimId = x.HekimId
                })
                .ToList();
        }
        public void DeleteByTc(string tc)
        {
            var entity = _context.KayitliKisiListesi.FirstOrDefault(x => x.Tc == tc);
            if (entity != null)
            {
                _context.KayitliKisiListesi.Remove(entity);
                _context.SaveChanges();
            }
        }

    }
}
