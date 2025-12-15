using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class MhrsKayitDto
    {
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string Hekim { get; set; } 
        public TimeSpan Saat { get; set; }
        public DateTime Tarih { get; set; }
        public string Tc { get; set; }
        public int HekimId { get; set; }
      
    
    }
}
