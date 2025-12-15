using Core.DTO;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class CinsiyetService
    {
        private readonly AppDbCon _context;

        public CinsiyetService(AppDbCon context)
        {
            _context = context;
        }

        public List<CinsiyetDto> GetAll()
        {
            return _context.Cinsiyetler
                .Select(x => new CinsiyetDto
                {
                    CinsiyetId = x.CinsiyetId,
                    CinsiyetAdi = x.CinsiyetAdi
                })
                .ToList();
        }
    }
}
