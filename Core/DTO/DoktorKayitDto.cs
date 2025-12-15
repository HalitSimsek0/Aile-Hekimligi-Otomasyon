using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class DoktorKayitDto
    {
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; } 
        public DateTime Dogumtarih { get; set; }
        public int Yas { get; set; }
        public string Telefon { get; set; }

        public int CinsiyetId { get; set; }
        public int HekimId { get; set; }

    }
}
