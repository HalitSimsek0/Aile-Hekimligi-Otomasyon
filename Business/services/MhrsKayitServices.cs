using Core.DTO;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class MhrsKayitServices
    {
        private readonly AppDbCon _context;

        public MhrsKayitServices(AppDbCon context)
        {
            _context = context;
        }

        public void Add(MhrsKayit kayit)
        {
            _context.MhrsKayitlar.Add(kayit);
            _context.SaveChanges();
        }

        public List<MhrsKayitDto> GetAll()
        {
            return _context.MhrsKayitlar
                .Include(x => x.Hekim)
                .Select(x => new MhrsKayitDto
                {
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                   
                    Saat = x.Saat,
                    Tarih = x.Tarih,
                    Tc = x.Tc,
                    HekimId = x.HekimId,
                    Hekim = x.Hekim.Ad + " " + x.Hekim.Soyad
                })
                .ToList();
        }
        public void DeleteByTc(string tc)
        {
            var entity = _context.MhrsKayitlar.FirstOrDefault(x => x.Tc == tc);
            if (entity != null)
            {
                _context.MhrsKayitlar.Remove(entity);
                _context.SaveChanges();
            }
        }

    }
}
