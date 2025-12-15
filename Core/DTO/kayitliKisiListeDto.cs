using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class KayitliKisiListeDto
    {
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime Dogumtarih { get; set; }
        public string AnneAd { get; set; }
        public int Yas { get; set; }
        public string BabaAd { get; set; }
        public string Telefon { get; set; }
        
        public string Hekim { get; set; }
        public int HekimId { get; set; }

    }
}