using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class KabulListeDto
    {
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime Dogumtarih { get; set; }
        public int Yas { get; set; }
        public string TamamlanmaDurumu { get; set; }
        public bool OncelikliMi { get; set; }
        public int HekimId { get; set; }
        public string Hekim { get; set; }
    }
}
