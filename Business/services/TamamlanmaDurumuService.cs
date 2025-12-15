using System.Collections.Generic;
using System.Linq;
using Core.DTO;
using DataAccess;
using Entities;

namespace Business.Services 
{
    public class TamamlanmaDurumuService
    {
        private readonly AppDbCon _context;

        public TamamlanmaDurumuService(AppDbCon context)
        {
            _context = context;
        }

        public List<TamamlanmaDurumuDto> GetAll()
        {
            return _context.TamamlanmaDurumlari
                .Select(x => new TamamlanmaDurumuDto
                {
                    TamamlanmaDurumuId = x.TamamlanmaDurumuId,
                    DurumAdi = x.DurumAdi
                })
                .ToList();
        }
    }
}
