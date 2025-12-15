
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Linq;
using Core.DTO;

namespace Business.Services
{
    public class MisafirService
    {
        private readonly AppDbCon _context;
        private readonly DoktorKayitService _doktorKayitService; 

        public MisafirService(AppDbCon context, DoktorKayitService doktorKayitService)
        {
            _context = context;
            _doktorKayitService = doktorKayitService;
        }

        public void Add(MisafirDto dto)
        {
            var doktor = _context.DoktorKayitlari.FirstOrDefault(x => x.HekimId == dto.HekimId);

            var misafir = new Misafir
            {
                Tc = dto.Tc,
                HekimId = dto.HekimId
            };

            _context.Misafirler.Add(misafir);
            _context.SaveChanges();

           
            if (doktor != null)
            {
                dto.Hekim = doktor.Ad + " " + doktor.Soyad;
            }
        }


        public MisafirDto GetMisafirByTc(string tc)
        {
            var misafirDto = _context.Misafirler
                .Include(m => m.Hekim)
                .Where(m => m.Tc.Trim() == tc.Trim())
                .Select(m => new MisafirDto
                {
                    MisafirId = m.MisafirId,
                    Tc = m.Tc,
                    HekimId = m.HekimId,
                    Hekim = m.Hekim != null
                                    ? m.Hekim.Ad + " " + m.Hekim.Soyad
                                    : "Belirtilmemiş Doktor"
                })
                .FirstOrDefault();

            if (misafirDto == null)
                throw new KeyNotFoundException($"TC '{tc}' ile misafir bulunamadı.");

            return misafirDto;
        }


        public List<MisafirDto> GetAll()
        {
            return _context.Misafirler
                .Include(m => m.Hekim) 
                .Select(m => new MisafirDto
                {
                    MisafirId = m.MisafirId,
                    Tc = m.Tc,
                    HekimId = m.HekimId,
                    Hekim = m.Hekim != null ? m.Hekim.Ad + " " + m.Hekim.Soyad : "Belirtilmemiş"
                })
                .ToList();
        }
        public void DeleteByTc(string tc)
        {
            var entity = _context.Misafirler.FirstOrDefault(x => x.Tc == tc);
            if (entity != null)
            {
                _context.Misafirler.Remove(entity);
                _context.SaveChanges();
            }
        }

    }
}