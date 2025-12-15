using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class DoktorKabulDurumuDto
    {
        public string HekimAd { get; set; }
        public int ToplamKabul { get; set; }
        public int TamamlananKabul { get; set; }
        public int BekleyenKabul { get; set; }
        public int KayitliKabul { get; set; }
        public int MisafirKabul { get; set; }
        public int HekimId { get; set; }
    }
}
