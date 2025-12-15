using Core.DTO;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class DoktorKayitService
    {
        private readonly AppDbCon _context;

        public DoktorKayitService(AppDbCon context)
        {
            _context = context;
        }

        public List<DoktorKayitDto> GetAll()
        {
            return _context.DoktorKayitlari
                .Include(x => x.Cinsiyet)
                .Select(x => new DoktorKayitDto
                {
                    Tc = x.Tc,
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                    Cinsiyet = x.Cinsiyet.CinsiyetAdi,
                    Dogumtarih = x.Dogumtarih,
                    Yas = x.Yas,
                    Telefon = x.Telefon,
                    CinsiyetId = x.CinsiyetId,
                     HekimId = x.HekimId
                })
                .ToList();
        }
        public DoktorKayit GetDoctorWithLeastPatients()
        {
          
            var doctorPatientCounts = _context.KabulListeleri
                                            .GroupBy(k => k.HekimId)
                                            .Select(g => new { HekimId = g.Key, PatientCount = g.Count() })
                                            .ToList();

           
            var allDoctors = _context.DoktorKayitlari.ToList();

           
            var doctorsWithCounts = allDoctors.Select(d => new
            {
                Doctor = d,
                PatientCount = doctorPatientCounts.FirstOrDefault(x => x.HekimId == d.HekimId)?.PatientCount ?? 0
            }).ToList();


            var leastPatientDoctor = doctorsWithCounts.OrderBy(x => x.PatientCount)
                                                    .Select(x => x.Doctor)
                                                    .FirstOrDefault();

        
            if (leastPatientDoctor == null && allDoctors.Any())
            {
                return allDoctors.First(); 
            }

            return leastPatientDoctor;
        }

     
        public DoktorKayit GetRandomDoctor()
        {
            var allDoctors = _context.DoktorKayitlari.ToList();
            if (!allDoctors.Any())
            {
                return null;
            }
            Random rand = new Random();
            int index = rand.Next(allDoctors.Count);
            return allDoctors[index];
        }

        public DoktorKayit GetById(int id)
        {
            return _context.DoktorKayitlari.Find(id);
        }
        public void Add(DoktorKayit doktor)
        {
            _context.DoktorKayitlari.Add(doktor);
            _context.SaveChanges();
        }
        public void DeleteByTc(string tc)
        {
            var entity = _context.DoktorKayitlari.FirstOrDefault(x => x.Tc == tc);
            if (entity != null)
            {
                _context.DoktorKayitlari.Remove(entity);
                _context.SaveChanges();
            }
        }

    }
}
