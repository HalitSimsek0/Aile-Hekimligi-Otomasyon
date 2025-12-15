using Core.DTO;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class DoktorKabulDurumuServices
    {
        private readonly AppDbCon _context;

        public DoktorKabulDurumuServices(AppDbCon context)
        {
            _context = context;
        }

        public List<DoktorKabulDurumuDto> GetAll()
        {
            return _context.DoktorKabulDurumlari
                .Include(x => x.Hekim)
                .Select(x => new DoktorKabulDurumuDto
                {
                    HekimAd = x.Hekim.Ad + " " + x.Hekim.Soyad,
                    ToplamKabul = x.AlinanKabulSayisi + x.MisafirKabulSayisi,
                    TamamlananKabul = x.AlinanKabulSayisi,
                    BekleyenKabul = 0, 
                    KayitliKabul = x.AlinanKabulSayisi,
                    MisafirKabul = x.MisafirKabulSayisi
                })
                .ToList();
        }
    }
}
